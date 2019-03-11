namespace InterfaceSegregation

type IMachine =
    abstract member Print: Document -> unit
    abstract member Scan: Document -> unit
    abstract member Fax: Document -> unit

