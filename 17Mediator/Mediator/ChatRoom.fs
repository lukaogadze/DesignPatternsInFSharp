namespace Mediator

type ChatRoom() = 
    let mutable _people = List<IPerson>.Empty

    member this.Join(person: IPerson) =
        let joinMessage = sprintf "%s joins the chat" person.Name
        (this :> IChatRoom).Brodcast("room", joinMessage)

        person.ChatRoom <- Some(this :> IChatRoom)
        _people <- person::_people

    interface IChatRoom with
        member this.Brodcast(source: string, message: string) =
            for p in _people do
                if p.Name <> source then
                    p.ReceiveMessage(source, message)
    
        member this.Message(source, destination, message) =
            let personOrNone = _people |> List.tryFind (fun p -> p.Name = destination)
            match personOrNone with
            | Some p -> p.ReceiveMessage(source, message)
            | None -> ()
        