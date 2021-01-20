Imports Microsoft.Win32
Public Class ZorkifUSBDisabler
    Private Sub BtnDisableUSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisableUSB.Click

        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\USBSTOR", "Start", "00000004", RegistryValueKind.DWord)
            lblStatus.Text = "Status: Disabled"
            Beep()
        Catch ex As Exception
            MsgBox("Sorry!, It seems you do not have Administrative Rights to run this Application. Right Click on the Application Icon and choose 'Run as Administrator'", MsgBoxStyle.Information)

        End Try
    End Sub

    Private Sub BtnEnableUSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnableUSB.Click

        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\services\USBSTOR", "Start", "00000003", RegistryValueKind.DWord)
            lblStatus.Text = "Status: Enabled"
            Beep()
        Catch ex As Exception
            MsgBox("Sorry!, It seems you do not have Administrative Rights to run this Application. Right Click on the Application Icon and choose 'Run as Administrator'", MsgBoxStyle.Information)

        End Try

    End Sub

    Private Sub ZorkifUSBDisabler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
