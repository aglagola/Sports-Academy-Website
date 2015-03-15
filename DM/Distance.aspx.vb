Imports System.Data
Public Class Location
    Public Property lat As Double
    Public Property lon As Double
    Public Property City As String
End Class
Partial Class Default7
    Inherits System.Web.UI.Page

    Const pi = 3.1415926535897931
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim City As New Location
        Dim lat1 As Double
        Dim lon1 As Double
        Dim lat2 As Double
        Dim lon2 As Double

        Dim CityTable As DataView = CType(SqlDataSource1.Select(DataSourceSelectArguments.Empty), DataView)

        For Each CityRow As DataRowView In CityTable
            City.City = CityRow("Id")
            City.City = CityRow("City")
            City.lat = CityRow("CityLatitude")
            City.lon = CityRow("CityLongitude")

            If City.City = ListBox1.SelectedValue Then
                lat1 = City.lat
                lon1 = City.lon
            End If

            If City.City = ListBox2.SelectedValue Then
                lat2 = City.lat
                lon2 = City.lon
            End If
        Next
        Label1.Text = Distance(lat1, lon1, lat2, lon2)
    End Sub
    Function Distance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double) As Double
        Dim theta As Double, dist As Double
        theta = lon1 - lon2
        dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta)))
        ' Label1.Text = "dist = " & dist
        dist = acos(dist)
        dist = rad2deg(dist)
        Distance = dist * 60 * 1.1515
        Return dist
    End Function

    Function acos(ByVal rad As Double) As Double
        If Math.Abs(rad) <> 1 Then
            acos = pi / 2 - Math.Atan(rad / Math.Sqrt(1 - rad * rad))
        ElseIf rad = -1 Then
            acos = pi
        End If
        Return acos
    End Function

    Function deg2rad(ByVal deg As Double) As Double
        deg2rad = CDbl(deg * pi / 180)
        Return deg2rad
    End Function

    Function rad2deg(ByVal Rad As Double) As Double
        rad2deg = CDbl(Rad * 180 / pi)
        Return rad2deg
    End Function


End Class
