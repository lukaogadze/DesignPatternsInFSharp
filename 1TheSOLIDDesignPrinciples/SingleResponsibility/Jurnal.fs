namespace SingleResponsibility
open System
open System.IO
open System.Collections.Generic

type Jurnal() =
    let _entries = List<string>()
    [<DefaultValue>] static val mutable private count: int;
    
    member this.AddEntry(text: string): int =
        Jurnal.count <- Jurnal.count + 1
        _entries.Add (sprintf "%d: %s" Jurnal.count text)
        Jurnal.count // Momento
        
    member this.RemoveEntry(index: int): unit =
        _entries.RemoveAt index
        
    member this.Save(fileName):unit =
        File.WriteAllText(fileName, this.ToString())
        
    static member Load(fileName: string): Jurnal =
        Jurnal()
        
    member this.Load(uri: Uri) = ()        
        
    
    override this.ToString() =
        String.Join(Environment.NewLine, _entries)
        