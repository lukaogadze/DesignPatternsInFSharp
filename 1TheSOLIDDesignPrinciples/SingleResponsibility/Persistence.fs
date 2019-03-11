namespace SingleResponsibility
open System.IO

type Persistence() =
    member this.SaveToFile(jurnal: Jurnal, fileName: string, ?overwrite: bool): unit =
        if (defaultArg overwrite false || not (File.Exists fileName)) then
            File.WriteAllText(fileName, jurnal.ToString())        