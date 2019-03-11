namespace Adapter

type Demo() =
    static let _vectorObjects = [VectorRectangle(1,1,10,10); VectorRectangle(3,3,6,6)]
    member this.DrawPoint (point: Point) = 
        printf "."
    member this.Draw() =
        for vo in _vectorObjects do
            for line in vo do
                let adapter = LineToPointAdapter(line)
                Seq.iter (fun i -> this.DrawPoint(i)) adapter
