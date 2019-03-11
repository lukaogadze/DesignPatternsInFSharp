namespace Adapter

open System.Linq
open System.Collections
open System.Collections.Generic
open System

type LineToPointAdapter(line : Line) =
    static let mutable _count = 0
    static let _cache = Dictionary<int, List<Point>>()
    do
        let hash = line.GetHashCode()
        if _cache.ContainsKey(hash)
            then ()
        else
            _count <- _count + 1
            printfn "%d: Generating points for line [%d,%d]-[%d,%d]"
                _count (line.Start.X) (line.Start.Y) (line.End.X) (line.End.Y)
            let points = List<Point>()
            let left = Math.Min(line.Start.X, line.End.X)
            let right = Math.Max(line.Start.X, line.End.X)
            let top = Math.Min(line.Start.Y, line.End.Y)
            let bottom = Math.Max(line.Start.Y, line.End.Y)
            let dx = right - left
            let dy = line.End.Y - line.Start.Y
            if dx = 0 then
                for y = top to bottom do
                    points.Add(Point(left, y))
            elif dy = 0 then
                for x = left to right do
                    points.Add(Point(x, top))
            _cache.Add(hash, points)
            
    interface IEnumerable<Point> with            
        member this.GetEnumerator(): IEnumerator<Point> =
            let data = (_cache.Values.SelectMany(fun x -> x.Select(fun y -> y)))
            data.GetEnumerator()
            
        member this.GetEnumerator(): IEnumerator =
            (this :> IEnumerable<Point>).GetEnumerator() :> IEnumerator                              