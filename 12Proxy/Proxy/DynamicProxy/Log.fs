namespace Proxy.DynamicProxy

open System.Collections.Generic
open System
open ImpromptuInterface
open System.Dynamic
open System.Text

type Log<'T when 'T: not struct and 'T:(new : unit -> 'T)>(subject: 'T) =
    inherit DynamicObject()
    let _methodCallCount = Dictionary<string, int>()
    
    static member As<'I when 'I: not struct>() =
        if not (typeof<'I>.IsInterface) then
            raise (ArgumentException("'I must be an interface type!"))
        Log<'T>(Activator.CreateInstance<'T>()).ActLike<'I>()
    
    override this.TryInvokeMember(binder: InvokeMemberBinder, args: obj[], result: byref<obj>) =
        try
            printfn "Invoking %s.%s with arguments [%s]" (subject.GetType().Name) (binder.Name) (String.Join(",", args))
            if _methodCallCount.ContainsKey(binder.Name) then
                _methodCallCount.[binder.Name] <- _methodCallCount.[binder.Name] + 1
            else
                _methodCallCount.Add(binder.Name, 1)
            result <- subject.GetType().GetMethod(binder.Name).Invoke(subject, args)
            true
        with
        | _ ->
            result <- null   
            false
    
    member this.Info
        with get() =
            let sb = StringBuilder()
            for pair in _methodCallCount do
                sb.AppendLine(sprintf "%s called %d time(s)" pair.Key pair.Value) |> ignore
            sb.ToString()
            