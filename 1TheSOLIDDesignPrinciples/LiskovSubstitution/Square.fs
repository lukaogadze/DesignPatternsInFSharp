namespace LiskovSubstitution

type Square() = 
    inherit Rectangle()
    override this.Width 
        with set value =
            base.Width <- value
            base.Height <- value

    override this.Height 
        with set value =
            base.Width <- value
            base.Height <- value