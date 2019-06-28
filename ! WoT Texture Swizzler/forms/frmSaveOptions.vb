﻿Public Class frmSaveOptions

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        frmMain.save_file()
        Me.Hide()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Hide()
    End Sub

    Private Sub dx5_rb_CheckedChanged(sender As Object, e As EventArgs) Handles dx5_rb.CheckedChanged
        If dx5_rb.Checked Then
            mipmaps_cb.Enabled = True
            format_group_box.Enabled = True
        Else
            format_group_box.Enabled = False
            mipmaps_cb.Checked = False
            mipmaps_cb.Enabled = False
        End If

    End Sub

    Private Sub frmSaveOptions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If texture_help.Visible Then
            texture_help.Close()
        Else
            texture_help.Show()
        End If
    End Sub
End Class