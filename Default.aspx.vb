Imports System.IO
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub btn_CrearTXT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_CrearTXT.Click
        Dim fichero As String = tb_Ruta.Text
        Dim Texto As String = tb_Texto.Text
        lbl_Mostrar.Text = ""

        If fichero <> "" Then
            Dim sw As New System.IO.StreamWriter(fichero)
            sw.WriteLine(Texto)
            sw.Close()
        Else
            lbl_Mostrar.Text = "Debe ingresar la ruta del fichero"
        End If
    End Sub

    Protected Sub btn_leerTXT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_leerTXT.Click
        Dim fichero As String = tb_Ruta.Text
        Dim Texto As String = tb_Texto.Text

        If fichero <> "" Then
            Dim sr As New System.IO.StreamReader(fichero)
            Texto = sr.ReadToEnd()
            sr.Close()
            lbl_Mostrar.Text = Texto
        Else
            lbl_Mostrar.Text = "Debe ingresar la ruta del fichero"
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tb_Ruta.Text = System.AppDomain.CurrentDomain.BaseDirectory
    End Sub
End Class
