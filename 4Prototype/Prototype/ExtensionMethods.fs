namespace Prototype

open System.IO
open System.Runtime.CompilerServices
open System.Runtime.Serialization.Formatters.Binary
open System.Xml.Serialization

[<Extension>]
type ExtensionMethods() =
    [<Extension>]
    static member inline DeepCopyBinary(self : 'a): 'a =
        use memoryStream = new MemoryStream()
        let formatter = BinaryFormatter()
        formatter.Serialize(memoryStream, self)
        memoryStream.Seek(0L, SeekOrigin.Begin) |> ignore
        let copy = formatter.Deserialize(memoryStream)
        memoryStream.Close()
        copy :?> 'a
        
    [<Extension>]
    static member inline DeepCopyXml(self : 'a): 'a =
        use memoryStream = new MemoryStream()
        let serializer = XmlSerializer(typeof<'a>)
        serializer.Serialize(memoryStream, self)
        memoryStream.Position <- 0L
        serializer.Deserialize memoryStream :?> 'a