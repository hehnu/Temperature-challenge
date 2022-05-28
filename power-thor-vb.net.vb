Module Player
' Auto-generated code below aims at helping you parse
' the standard input according to the problem statement.
' ---
' Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.

    Sub Main ()
        
        Dim inputs as String()
        Dim lightX as Integer ' the X position of the light of power
        Dim lightY as Integer ' the Y position of the light of power
        Dim initialTX as Integer ' Thor's starting X position
        Dim initialTY as Integer ' Thor's starting Y position
        Dim direction as String
        inputs = Console.ReadLine().Split(" ")
        lightX = inputs(0)
        lightY = inputs(1)
        initialTX = inputs(2)
        initialTY = inputs(3)

        ' game loop
        While True
            Dim remainingTurns as Integer
            remainingTurns = Console.ReadLine() ' The remaining amount of turns Thor can move. Do not remove this line.

            ' Write an action using Console.WriteLine()
            ' To debug: Console.Error.WriteLine("Debug messages...")
         If lightX <>initialTX Then
           If lightX > initialTX 
            direction = "E"
            Else
            direction = "W"
            End If
        End If
        If lightY <>initialTX Then
           If lightY > initialTY
            direction = "S"
            Else
            direction = "N"
            End If
        End If

        If (lightX - initialTX) = (lightY-initialTY)
        If lightX > initialTX AND lightY > initialTY
        direction = "SE"
        End If
         If lightX > initialTX AND lightY < initialTY 
        direction = "NE"
          End If
         If lightX < initialTX AND lightY > initialTY 
        direction = "NW"
          End If
         If lightX < initialTX AND lightY < initialTY 
        direction = "SW"
        End If

    End If

    Dim SlopeX
     Dim SlopeY

    SlopeX = lightX - initialTX
    SlopeY = lightY - initialTY

    If SlopeX = 0 Then
        if lightY > initialTY Then
        direction = "S"
        initialTY = initialTY + 1
    Else
        direction = "N"
        initialTY = initialTY - 1
    End if
Else
    If SlopeY = 0 Then
        If lightX > initialTX Then
            direction = "E"
            initialTX = initialTX + 1
Else
    direction = "W"
    initialTX = initialTX - 1
    End If
Else

    If SlopeX > 0 AND SlopeY > 0 Then
    direction = "SE"
    initialTX = initialTX + 1
    initialTY = initialTY + 1
    End if

    If SlopeX < 0 AND SlopeY > 0 Then
    direction = "SW"
    initialTX = initialTX - 1
    initialTY = initialTY + 1
    End If

    If SlopeX > 0 AND SlopeY < 0 Then
    direction = "NE"
    initialTX = initialTX + 1
    initialTY = initialTY - 1
    End if

    If SlopeX < 0 AND SlopeY < 0 Then
        direction = "NW"
        initialTX = initialTX - 1
        initialTY = initialTY - 1
    End if
End if
End if





        
            ' A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(direction)
        End While
    End Sub
End Module
