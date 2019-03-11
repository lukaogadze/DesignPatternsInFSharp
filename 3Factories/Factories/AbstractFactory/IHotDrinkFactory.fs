namespace Factories.AbstractFactory

type IHotDrinkFactory =
    abstract member Prepare : int -> IHotDrink