namespace NullObject.DynamicNullObject

open System.Dynamic
open System
open ImpromptuInterface

type Null<'TInterface when 'TInterface: not struct>() =
    inherit DynamicObject()

    static member Instance: 'TInterface = Null<'TInterface>().ActLike<'TInterface>()
    
    override this.TryInvokeMember(binder: InvokeMemberBinder, args: obj[], result: byref<obj>) =
        result <- Activator.CreateInstance(binder.ReturnType)
        true