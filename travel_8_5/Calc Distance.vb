'Project:       Programming Exercise 8.5
'Date:          10/14/2012
'Programmer:    Angelo Maragos
'Description:   This program calculates distance between select cities 

Public Class calcForm

    ' declare array

    Dim travelInteger(,) As Integer =
        {{0I, 1004I, 1753I, 2752I, 3017I, 1520I, 1507I, 609I, 3155I, 448I},
         {1004I, 0I, 921I, 1780I, 2048I, 1397I, 919I, 515I, 2176I, 709I},
         {1753I, 921I, 0I, 1230I, 1399I, 1343I, 517I, 1435I, 2234I, 1307I},
         {2752I, 1780I, 1230I, 0I, 272I, 2570I, 1732I, 2251I, 1322I, 2420I},
         {3017I, 2048I, 1399I, 272I, 0I, 2716I, 1858I, 2523I, 1278I, 2646I},
         {1520I, 1397I, 1343I, 2570I, 2716I, 0I, 860I, 1494I, 3447I, 1057I},
         {1507I, 919I, 517I, 1732I, 1858I, 860I, 0I, 1307I, 2734I, 1099I},
         {609I, 515I, 1435I, 2251I, 2523I, 1494I, 1307I, 0I, 2820I, 571I},
         {3155I, 2176I, 2234I, 1322I, 1278I, 3447I, 2734I, 2820I, 0I, 2887I},
         {448I, 709I, 1307I, 2420I, 2646I, 1057I, 1099I, 571I, 2887I, 0I}}


    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()

        'exits program

    End Sub




    Private Sub btnLookUp_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUp.Click

        'declare variables

        Dim destIndex As Integer
        Dim departIndex As Integer


        ' set equal to the index value of comboBox items
        departIndex = ComboBoxDepart.SelectedIndex
        destIndex = ComboBoxDest.SelectedIndex


        'catch exception...not making two selections, one in each drop down

        Try

            lblAnswer.Text = travelInteger(departIndex, destIndex).ToString()

        Catch ex As Exception


            MessageBox.Show(" Make a selection in both fields.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try


    End Sub
End Class
