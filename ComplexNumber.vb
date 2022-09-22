Option Explicit On
Option Strict On

Public Class ComplexNumber

    Dim _real As Double
    Dim _imaginario As Double

    Public Sub New()
        _real = 0
        _imaginario = 0
    End Sub

    Public Sub Dispose()
        _real = 0
        _imaginario = 0
    End Sub

    Public Sub Establecer(ByVal real As Double, ByVal imaginario As Double)
        _real = real
        _imaginario = imaginario
    End Sub

    Public Overrides Function ToString() As String
        Return CStr(_real) & "+" & CStr(_imaginario) & "i"
    End Function

    Public Function Suma(ByVal Sumando As ComplexNumber) As ComplexNumber
        Dim _ComplejoAux As ComplexNumber = New ComplexNumber()

        _ComplejoAux._real = Me._real + Sumando._real
        _ComplejoAux._imaginario = Me._imaginario + Sumando._imaginario

        Return _ComplejoAux
    End Function

    Public Function Resta(ByVal sustraendo As ComplexNumber) As ComplexNumber
        Dim _ComplejoAux As ComplexNumber = New ComplexNumber()

        _ComplejoAux._real = Me._real - sustraendo._real
        _ComplejoAux._imaginario = Me._imaginario - sustraendo._imaginario

        Return _ComplejoAux
    End Function

    Public Function Multiplicacion(ByVal Multiplicando As ComplexNumber) As ComplexNumber
        Dim _ComplejoAux As ComplexNumber = New ComplexNumber()
        '(A*C-B*D)
        _ComplejoAux._real = (Me._real * Multiplicando._real) - (Me._imaginario * Multiplicando._imaginario)
        '(A*D+B*C)i
        _ComplejoAux._imaginario = (Me._real * Multiplicando._imaginario) + (Me._imaginario * Multiplicando._real)
        Return _ComplejoAux
    End Function

    Public Function Multiplicacion(ByVal NumeroReal As Double) As ComplexNumber
        Dim _ComplejoAux As ComplexNumber = New ComplexNumber()
        '(xA,xBi)
        _ComplejoAux._real = NumeroReal * Me._real
        _ComplejoAux._imaginario = NumeroReal * Me._imaginario

        Return _ComplejoAux
    End Function

End Class
