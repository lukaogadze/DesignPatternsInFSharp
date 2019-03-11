namespace Adapter


type VectorRectangle(x, y, width, height) as self =
    inherit VectorObject()
    do          
        self.Add(Line(Point(x, y), Point(x + width, y)))
        self.Add(Line(Point(x + width, y), Point(x + width, y + height)))
        self.Add(Line(Point(x, y), Point(x, y + height)))
        self.Add(Line(Point(x, y + height), Point(x + width, y + height)))
        