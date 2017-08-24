Public Class PaginaPrincipal
#Region "Enumerador"


    Enum infra
        AP
        Switch
        Servidor
        Router
        Transeiver
        Firewall
        UPS
    End Enum


    Enum Monitores
        Sansung
        HP
        LG

    End Enum
    Enum otrosEquipos
        DockingStation
        Proyectores
        Polycom

    End Enum



#End Region


    Private Sub PCTabletsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PCTabletsToolStripMenuItem.Click
        Dim frmPC As New frmPC

        frmPC.Text = "PC, Notebook y tablet"
        frmPC.Parent = Me.Parent
        frmPC.ShowDialog()

    End Sub

    Private Sub InfraEstructuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfraEstructuraToolStripMenuItem.Click
        Dim frmInfra As New frmInfraEstructura

        frmInfra.Parent = Me.Parent
        frmInfra.ShowDialog()

    End Sub

    Private Sub MonitoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitoresToolStripMenuItem.Click
        Dim tablet As New frmTablet
        tablet.Parent = Me.Parent
        tablet.ShowDialog()


    End Sub

    Private Sub TecnicosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecnicosToolStripMenuItem.Click
        Dim Tecnicos As New frmTecnica
        Tecnicos.Parent = Me.Parent
        Tecnicos.ShowDialog()

    End Sub

    Private Sub OtrosEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosEquiposToolStripMenuItem.Click
        Dim frmOtros As New frmOtrosDispositivos


        frmOtros.Parent = Me.Parent
        frmOtros.ShowDialog()

    End Sub

    Private Sub ScrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScrapToolStripMenuItem.Click
        Dim unFrmScrap As New frmScrap

        unFrmScrap.Parent = Me.Parent
        unFrmScrap.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MicroinformaticaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicroinformaticaToolStripMenuItem.Click

    End Sub
End Class