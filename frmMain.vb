#If False Then
Copyright © 2015 Russell Dillin

This file is part of RestartSpooler.

RestartSpooler is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

RestartSpooler is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with RestartSpooler.  If not, see <http://www.gnu.org/licenses/>.
#End If

Imports System.ComponentModel
Imports System.ServiceProcess
Imports System.Threading

''' <summary>
''' A Simple, One-Button Solution
''' to Restart the Print Spooler.
''' </summary>
''' <remarks>
''' Russell Dillin
''' 07/16/2015
''' </remarks>
Public Class frmMain
	Public Sub New()
		InitializeComponent()
		bgWorker.WorkerReportsProgress = True
	End Sub

	Private Sub frmMain_Load(sender As Object, _
							 e As EventArgs) _
		Handles Me.Load
		Try
			Dim spoolerPermissions As ServiceControllerPermission = _
					New ServiceControllerPermission( _
					ServiceControllerPermissionAccess.Control, _
					System.Environment.MachineName, _
					"Spooler")
			spoolerPermissions.Assert()
		Catch ex As Exception
			'Fail silently into the night.
		End Try
	End Sub

	Private Sub btnRestartSpooler_Click(sender As Object, _
										e As EventArgs) _
		Handles btnRestartSpooler.Click
		Me.btnRestartSpooler.Enabled = False
		Me.UseWaitCursor = True
		If Me.bgWorker.IsBusy <> True Then
			bgWorker.RunWorkerAsync()
		End If
	End Sub

	Private Sub bgWorker_RunWorkerCompleted(sender As Object, _
											e As EventArgs) _
		Handles bgWorker.RunWorkerCompleted
		Me.UseWaitCursor = False
		Me.btnRestartSpooler.Enabled = True
	End Sub

	Private Sub bgWorker_DoWork(sender As Object, _
								e As DoWorkEventArgs) _
		Handles bgWorker.DoWork
		Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
		Dim spoolerIndex As Integer = 0
		Dim spoolerFound As Boolean = False
		Dim services() As ServiceController
		Dim machineName As String = _
			New String(System.Environment.MachineName)
		services = ServiceController.GetServices(machineName)

		For Each serv As ServiceController In services
			If serv.ServiceName = "Spooler" Then
				spoolerFound = True
				spoolerIndex = _
					Array.IndexOf(services, serv)
			End If
		Next
		If spoolerFound Then
			Dim spooler As ServiceController = services(spoolerIndex)
			Try
				If spooler.Status <> _
					   ServiceControllerStatus.Stopped Then
					worker.ReportProgress(0, "Stopping.")
					Thread.Sleep(1000)
					spooler.Stop()
					worker.ReportProgress(0, "....5")
					Thread.Sleep(1000)
					worker.ReportProgress(0, "...4.")
					Thread.Sleep(1000)
					worker.ReportProgress(0, "..3..")
					Thread.Sleep(1000)
					worker.ReportProgress(0, ".2...")
					Thread.Sleep(1000)
					worker.ReportProgress(0, "1....")
					Thread.Sleep(1000)
					spooler.Refresh()
				End If
				worker.ReportProgress(0, "Starting.")
				spooler.Start()
				While (spooler.Status = _
							   ServiceControllerStatus.Stopped)
					Thread.Sleep(1000)
					spooler.Refresh()
				End While
				While (spooler.Status <> _
							   ServiceControllerStatus.Running)
					Thread.Sleep(1000)
					spooler.Refresh()
				End While
				worker.ReportProgress(0, "Restarted!")
			Catch ex As InvalidOperationException
				'Does not have adequate permissions.
			End Try
		Else
			worker.ReportProgress(0, "No Spooler.")
		End If
	End Sub

	Private Sub bgWorker_ProgressChanged(sender As Object, _
										 e As ProgressChangedEventArgs) _
		Handles bgWorker.ProgressChanged
		Me.lblStatusText.Text = e.UserState
	End Sub
End Class
