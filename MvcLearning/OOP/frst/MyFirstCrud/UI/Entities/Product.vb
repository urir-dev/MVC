﻿Public Class Product
    Public FreindID As String
    Public Name As String
    Public Image As String
    Public CreateDate As DateTime
    Public NotImportentData As String

    Sub New()

        Me.CreateDate = New Date()
        Me.NotImportentData = "Do Not Display!"

    End Sub
    Sub New(
        FreindID As String,
        name As String,
        Image As String
        )
        Me.FreindID = FreindID
        Me.Name = name
        Me.Image = Image
        Me.CreateDate = New Date()
        Me.NotImportentData = "Do Not Display!"

    End Sub
End Class