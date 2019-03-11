namespace Flyweight.TextFormatter

type TextRange(start: int, aEnd: int) =
    [<DefaultValue>]
    val mutable private _capitalize: bool
    [<DefaultValue>]
    val mutable private _bold: bool
    [<DefaultValue>]
    val mutable private _italic: bool
    
    member this.Start = start               
    member this.End = aEnd
    
    member this.Capitalize = this._capitalize
    member this.Bold = this._bold
    member this.Italic = this._italic
    
    member this.Covers(position: int): bool =
        position >= this.Start && position <= this.End
        
    member this.WithCapitalize(capitalize) =
        this._capitalize <- capitalize
        this
        
    member this.WithBold(bold) =
        this._bold <- bold
        this
        
    member this.WithItalic(italic) =
        this._bold <- italic
        this
        
    
    
    
    
    
    
    
//    member member this.Start =
//        with get() 
//    member val End = aEnd
//    member val Capitalize = false with get, set
//    member val Bold = false with get, set
//    member val Italic = false

