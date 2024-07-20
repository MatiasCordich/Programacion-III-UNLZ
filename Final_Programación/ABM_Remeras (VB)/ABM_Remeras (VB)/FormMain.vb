﻿Imports ABM_Remera_Services.Models

Public Class FormMain

    'Creamos la lista padre de Remeras'
    Private listaRemeras As List(Of Remera)

    'Creamos los formularios hijos'
    Private formAlta As FormAltaRemera
    Private formBaja As FormBajaRemera
    Private formEditar As FormEditarRemera

    ' ------------- CONSTRUCTOR ------------- 
    Public Sub New()

        InitializeComponent()

        ' Inicializamos la lista del Formulario Principal
        Me.listaRemeras = New List(Of Remera)()
    End Sub

    ' Menu alta de Remera
    Private Sub AltaDeRemeraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeRemeraToolStripMenuItem.Click

        'Verifico si no hay un formulario de Alta
        If formAlta Is Nothing Then

            'Si no hay, lo instanciamos y le pasamos el formulario padre'
            formAlta = New FormAltaRemera(Me.listaRemeras)

            'Le definimos el MdiParent'
            formAlta.MdiParent = Me

            'Manejamos el cierro del formulario'
            AddHandler formAlta.FormClosed, AddressOf FormAltaRemeras_FormClosed

            ' Mostramos el formulario de alta
            formAlta.Show()
        End If
    End Sub

    ' ------------- HANDLERS ------------- 
    Private Sub FormAltaRemeras_FormClosed(sender As Object, e As FormClosedEventArgs)
        formAlta = Nothing
    End Sub

    Private Sub FormEditarRemeras_FormClosed(sender As Object, e As FormClosedEventArgs)
        formEditar = Nothing
    End Sub

    Private Sub FormBajaRemeras_FormClosed(sender As Object, e As FormClosedEventArgs)
        formBaja = Nothing
    End Sub
End Class
