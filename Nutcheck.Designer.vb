﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Nutcheck
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtTgtStart = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblTimeout = New System.Windows.Forms.Label()
        Me.txtTimeout = New System.Windows.Forms.TextBox()
        Me.chkPing = New System.Windows.Forms.CheckBox()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lblSpinner = New System.Windows.Forms.Label()
        Me.chkTcp = New System.Windows.Forms.CheckBox()
        Me.chkUdp = New System.Windows.Forms.CheckBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblPortExample = New System.Windows.Forms.Label()
        Me.btnPreset1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtOrganizedResults = New System.Windows.Forms.TextBox()
        Me.btnPreset2 = New System.Windows.Forms.Button()
        Me.btnPreset3 = New System.Windows.Forms.Button()
        Me.btnPreset4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkIgnoreDead = New System.Windows.Forms.CheckBox()
        Me.chkVerboseMode = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(588, 7)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(137, 37)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "RUN TEST"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtTgtStart
        '
        Me.txtTgtStart.Location = New System.Drawing.Point(138, 34)
        Me.txtTgtStart.Name = "txtTgtStart"
        Me.txtTgtStart.Size = New System.Drawing.Size(302, 20)
        Me.txtTgtStart.TabIndex = 1
        Me.txtTgtStart.Text = "192.168.1.1"
        Me.txtTgtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(461, 34)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(120, 20)
        Me.txtPort.TabIndex = 19
        Me.txtPort.Text = "20-22, 80, 443"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPort
        '
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(461, 12)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(120, 20)
        Me.lblPort.TabIndex = 23
        Me.lblPort.Text = "Ports"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIP
        '
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(134, 12)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(306, 20)
        Me.lblIP.TabIndex = 22
        Me.lblIP.Text = "Destination(s)"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeout
        '
        Me.lblTimeout.Location = New System.Drawing.Point(11, 58)
        Me.lblTimeout.Name = "lblTimeout"
        Me.lblTimeout.Size = New System.Drawing.Size(51, 20)
        Me.lblTimeout.TabIndex = 26
        Me.lblTimeout.Text = "Timeout:"
        Me.lblTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTimeout
        '
        Me.txtTimeout.Location = New System.Drawing.Point(68, 59)
        Me.txtTimeout.Name = "txtTimeout"
        Me.txtTimeout.Size = New System.Drawing.Size(48, 20)
        Me.txtTimeout.TabIndex = 25
        Me.txtTimeout.Text = "2000"
        Me.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPing
        '
        Me.chkPing.AutoSize = True
        Me.chkPing.Checked = True
        Me.chkPing.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPing.Location = New System.Drawing.Point(34, 12)
        Me.chkPing.Name = "chkPing"
        Me.chkPing.Size = New System.Drawing.Size(71, 17)
        Me.chkPing.TabIndex = 27
        Me.chkPing.Text = "Ping Test"
        Me.chkPing.UseVisualStyleBackColor = True
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(9, 12)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(19, 13)
        Me.lblAbout.TabIndex = 29
        Me.lblAbout.Text = "@"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(116, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "ms"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'txtLog
        '
        Me.txtLog.Font = New System.Drawing.Font("Courier New", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(12, 108)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLog.Size = New System.Drawing.Size(378, 346)
        Me.txtLog.TabIndex = 35
        Me.txtLog.WordWrap = False
        '
        'lblSpinner
        '
        Me.lblSpinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpinner.Location = New System.Drawing.Point(284, 82)
        Me.lblSpinner.Name = "lblSpinner"
        Me.lblSpinner.Size = New System.Drawing.Size(23, 23)
        Me.lblSpinner.TabIndex = 36
        Me.lblSpinner.Text = "-"
        Me.lblSpinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSpinner.Visible = False
        '
        'chkTcp
        '
        Me.chkTcp.AutoSize = True
        Me.chkTcp.Checked = True
        Me.chkTcp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTcp.Location = New System.Drawing.Point(34, 27)
        Me.chkTcp.Name = "chkTcp"
        Me.chkTcp.Size = New System.Drawing.Size(71, 17)
        Me.chkTcp.TabIndex = 28
        Me.chkTcp.Text = "TCP Test"
        Me.chkTcp.UseVisualStyleBackColor = True
        '
        'chkUdp
        '
        Me.chkUdp.AutoSize = True
        Me.chkUdp.Checked = True
        Me.chkUdp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUdp.Enabled = False
        Me.chkUdp.Location = New System.Drawing.Point(34, 43)
        Me.chkUdp.Name = "chkUdp"
        Me.chkUdp.Size = New System.Drawing.Size(73, 17)
        Me.chkUdp.TabIndex = 33
        Me.chkUdp.Text = "UDP Test"
        Me.chkUdp.UseVisualStyleBackColor = True
        '
        'txtResults
        '
        Me.txtResults.Font = New System.Drawing.Font("Courier New", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(396, 108)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResults.Size = New System.Drawing.Size(329, 346)
        Me.txtResults.TabIndex = 40
        Me.txtResults.WordWrap = False
        '
        'lblPortExample
        '
        Me.lblPortExample.Location = New System.Drawing.Point(462, 57)
        Me.lblPortExample.Name = "lblPortExample"
        Me.lblPortExample.Size = New System.Drawing.Size(120, 20)
        Me.lblPortExample.TabIndex = 41
        Me.lblPortExample.Text = "Ex: 20-22, 80, 443"
        Me.lblPortExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPreset1
        '
        Me.btnPreset1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreset1.Location = New System.Drawing.Point(902, 16)
        Me.btnPreset1.Name = "btnPreset1"
        Me.btnPreset1.Size = New System.Drawing.Size(109, 28)
        Me.btnPreset1.TabIndex = 42
        Me.btnPreset1.Text = "Preset Test 1"
        Me.btnPreset1.UseVisualStyleBackColor = True
        Me.btnPreset1.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(731, 7)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(137, 37)
        Me.btnReset.TabIndex = 43
        Me.btnReset.Text = "<-- RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtOrganizedResults
        '
        Me.txtOrganizedResults.Font = New System.Drawing.Font("Courier New", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrganizedResults.Location = New System.Drawing.Point(731, 108)
        Me.txtOrganizedResults.Multiline = True
        Me.txtOrganizedResults.Name = "txtOrganizedResults"
        Me.txtOrganizedResults.ReadOnly = True
        Me.txtOrganizedResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOrganizedResults.Size = New System.Drawing.Size(422, 346)
        Me.txtOrganizedResults.TabIndex = 44
        Me.txtOrganizedResults.WordWrap = False
        '
        'btnPreset2
        '
        Me.btnPreset2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreset2.Location = New System.Drawing.Point(1017, 16)
        Me.btnPreset2.Name = "btnPreset2"
        Me.btnPreset2.Size = New System.Drawing.Size(109, 28)
        Me.btnPreset2.TabIndex = 45
        Me.btnPreset2.Text = "Preset Test 2"
        Me.btnPreset2.UseVisualStyleBackColor = True
        Me.btnPreset2.Visible = False
        '
        'btnPreset3
        '
        Me.btnPreset3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreset3.Location = New System.Drawing.Point(902, 47)
        Me.btnPreset3.Name = "btnPreset3"
        Me.btnPreset3.Size = New System.Drawing.Size(109, 28)
        Me.btnPreset3.TabIndex = 46
        Me.btnPreset3.Text = "Preset Test 3"
        Me.btnPreset3.UseVisualStyleBackColor = True
        Me.btnPreset3.Visible = False
        '
        'btnPreset4
        '
        Me.btnPreset4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreset4.Location = New System.Drawing.Point(1017, 47)
        Me.btnPreset4.Name = "btnPreset4"
        Me.btnPreset4.Size = New System.Drawing.Size(109, 28)
        Me.btnPreset4.TabIndex = 47
        Me.btnPreset4.Text = "Preset Test 4"
        Me.btnPreset4.UseVisualStyleBackColor = True
        Me.btnPreset4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Raw Log:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(393, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Raw Results:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(728, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Organized Results:"
        '
        'chkIgnoreDead
        '
        Me.chkIgnoreDead.AutoSize = True
        Me.chkIgnoreDead.Checked = True
        Me.chkIgnoreDead.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIgnoreDead.Location = New System.Drawing.Point(588, 50)
        Me.chkIgnoreDead.Name = "chkIgnoreDead"
        Me.chkIgnoreDead.Size = New System.Drawing.Size(127, 17)
        Me.chkIgnoreDead.TabIndex = 53
        Me.chkIgnoreDead.Text = "Ignore Failed Reports"
        Me.chkIgnoreDead.UseVisualStyleBackColor = True
        '
        'chkVerboseMode
        '
        Me.chkVerboseMode.AutoSize = True
        Me.chkVerboseMode.Location = New System.Drawing.Point(71, 88)
        Me.chkVerboseMode.Name = "chkVerboseMode"
        Me.chkVerboseMode.Size = New System.Drawing.Size(65, 17)
        Me.chkVerboseMode.TabIndex = 54
        Me.chkVerboseMode.Text = "Verbose"
        Me.chkVerboseMode.UseVisualStyleBackColor = True
        '
        'Nutcheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 463)
        Me.Controls.Add(Me.chkVerboseMode)
        Me.Controls.Add(Me.chkIgnoreDead)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPreset4)
        Me.Controls.Add(Me.btnPreset3)
        Me.Controls.Add(Me.btnPreset2)
        Me.Controls.Add(Me.txtOrganizedResults)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPreset1)
        Me.Controls.Add(Me.lblPortExample)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.lblSpinner)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblTimeout)
        Me.Controls.Add(Me.txtTimeout)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtTgtStart)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.chkPing)
        Me.Controls.Add(Me.chkTcp)
        Me.Controls.Add(Me.chkUdp)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Nutcheck"
        Me.Text = "Darren's Nutcheck"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents txtTgtStart As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents lblTimeout As Label
    Friend WithEvents txtTimeout As TextBox
    Friend WithEvents chkPing As CheckBox
    Friend WithEvents lblAbout As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblSpinner As Label
    Friend WithEvents chkTcp As CheckBox
    Friend WithEvents chkUdp As CheckBox
    Friend WithEvents txtResults As TextBox
    Friend WithEvents lblPortExample As Label
    Friend WithEvents btnPreset1 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtOrganizedResults As TextBox
    Friend WithEvents btnPreset2 As Button
    Friend WithEvents btnPreset3 As Button
    Friend WithEvents btnPreset4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkIgnoreDead As CheckBox
    Friend WithEvents chkVerboseMode As CheckBox
End Class
