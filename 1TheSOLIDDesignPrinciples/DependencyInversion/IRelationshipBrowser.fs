namespace DependencyInversion

type IRelationshipBrowser =
    abstract member FindAllChildrenOf: string -> seq<Person>
