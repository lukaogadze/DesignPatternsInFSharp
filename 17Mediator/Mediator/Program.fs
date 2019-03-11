module Mediator.Program

open System

let private demo1() =
    let room = ChatRoom()

    let john = Person("John") :> IPerson
    let jane = Person("Jane") :> IPerson

    room.Join(john)
    room.Join(jane)
    
    john.Say("hi")
    jane.Say("oh, hey John")

    let simon = Person("Simon") :> IPerson
    room.Join(simon)
    simon.Say("hi everyone!")

    jane.PrivateMessage(simon.Name, "glad you could join us!")



[<EntryPoint>]
let main argv =
    demo1()
    0
