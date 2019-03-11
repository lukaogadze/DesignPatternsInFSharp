namespace Singleton

type IDatabase =
    abstract member GetPopulation: string -> int
