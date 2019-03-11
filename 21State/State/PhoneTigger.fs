namespace State


type PhoneTigger =
    | CallDialed = 0
    | HungUp = 1
    | CallConnected = 2
    | PlaceOnHold = 3
    | TakenOffHold = 4
    | LeftMessage = 5

