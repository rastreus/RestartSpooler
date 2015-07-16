<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.btnRestartSpooler = New System.Windows.Forms.Button()
		Me.lblText = New System.Windows.Forms.Label()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.lblStatusText = New System.Windows.Forms.Label()
		Me.bgWorker = New System.ComponentModel.BackgroundWorker()
		Me.SuspendLayout()
		'
		'btnRestartSpooler
		'
		Me.btnRestartSpooler.BackColor = System.Drawing.Color.Crimson
		Me.btnRestartSpooler.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
		Me.btnRestartSpooler.FlatAppearance.BorderSize = 2
		Me.btnRestartSpooler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink
		Me.btnRestartSpooler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed
		Me.btnRestartSpooler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRestartSpooler.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRestartSpooler.ForeColor = System.Drawing.Color.LavenderBlush
		Me.btnRestartSpooler.Location = New System.Drawing.Point(15, 54)
		Me.btnRestartSpooler.Name = "btnRestartSpooler"
		Me.btnRestartSpooler.Size = New System.Drawing.Size(172, 30)
		Me.btnRestartSpooler.TabIndex = 0
		Me.btnRestartSpooler.Text = "Restart"
		Me.btnRestartSpooler.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnRestartSpooler.UseVisualStyleBackColor = False
		'
		'lblText
		'
		Me.lblText.BackColor = System.Drawing.Color.Transparent
		Me.lblText.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblText.ForeColor = System.Drawing.Color.DarkMagenta
		Me.lblText.Location = New System.Drawing.Point(12, 9)
		Me.lblText.Name = "lblText"
		Me.lblText.Size = New System.Drawing.Size(175, 30)
		Me.lblText.TabIndex = 1
		Me.lblText.Text = "Computer, please restart the print spooler."
		Me.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblStatus
		'
		Me.lblStatus.BackColor = System.Drawing.Color.Transparent
		Me.lblStatus.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.ForeColor = System.Drawing.Color.Indigo
		Me.lblStatus.Location = New System.Drawing.Point(12, 97)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(57, 18)
		Me.lblStatus.TabIndex = 2
		Me.lblStatus.Text = "Status: "
		'
		'lblStatusText
		'
		Me.lblStatusText.BackColor = System.Drawing.Color.Transparent
		Me.lblStatusText.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatusText.Location = New System.Drawing.Point(75, 94)
		Me.lblStatusText.Name = "lblStatusText"
		Me.lblStatusText.Size = New System.Drawing.Size(112, 23)
		Me.lblStatusText.TabIndex = 3
		'
		'bgWorker
		'
		Me.bgWorker.WorkerReportsProgress = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Thistle
		Me.CausesValidation = False
		Me.ClientSize = New System.Drawing.Size(214, 124)
		Me.Controls.Add(Me.lblStatusText)
		Me.Controls.Add(Me.lblStatus)
		Me.Controls.Add(Me.lblText)
		Me.Controls.Add(Me.btnRestartSpooler)
		Me.Cursor = System.Windows.Forms.Cursors.Hand
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "RestartSpooler"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnRestartSpooler As System.Windows.Forms.Button
	Friend WithEvents lblText As System.Windows.Forms.Label
	Friend WithEvents lblStatus As System.Windows.Forms.Label
	Friend WithEvents lblStatusText As System.Windows.Forms.Label
	Private WithEvents bgWorker As System.ComponentModel.BackgroundWorker

End Class
