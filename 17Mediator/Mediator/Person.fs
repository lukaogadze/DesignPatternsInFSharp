namespace Mediator


type Person(name: string) =
    let mutable _chatLog = List<string>.Empty    
    
    interface IPerson with
        member val ChatRoom: IChatRoom option = None with get, set
        member this.Name = name
        member this.Say(message: string) = 
            (this :> IPerson).ChatRoom.Value.Brodcast((this :> IPerson).Name, message)

        member this.PrivateMessage(who: string, message: string) =
            (this :> IPerson).ChatRoom.Value.Message((this :> IPerson).Name, who, message)

        member this.ReceiveMessage(sender: string, message: string) =
            let s = sprintf "%s: '%s'" sender message
            _chatLog <- s::_chatLog
            printfn "[%s's chat session] %s" (this :> IPerson).Name s