module SingleResponsibility.Program
open System.Diagnostics

[<EntryPoint>]
let main argv =
    let jurnal = Jurnal();
    jurnal.AddEntry "I cried today" |> ignore
    jurnal.AddEntry "I ate a bug" |> ignore
    printfn "%A" jurnal
    
    let p = Persistence()
    let fileName = @"c:\temp\some-file.txt"
    p.SaveToFile(jurnal, fileName, true);
    Process.Start("notepad", fileName) |> ignore
    0 // return an integer exit code
