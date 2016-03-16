Sub ScratchMacroI()
Dim oRng As Word.Range
Dim oRngDelete As Word.Range
Set oRng = ActiveDocument.Range
With oRng.Find
  .Text = "Location:"
  While .Execute
    oRng.Select
    Set oRngDelete = ActiveDocument.Bookmarks("\Line").Range
    oRngDelete.Delete
  Wend
End With
End Sub
Sub ScratchMacroII()
Dim oRng As Word.Range
Dim oRngDelete As Word.Range
Set oRng = ActiveDocument.Range
With oRng.Find
  .Text = "Status:"
  While .Execute
    oRng.Select
    Set oRngDelete = ActiveDocument.Bookmarks("\Line").Range
    oRngDelete.Delete
  Wend
End With
End Sub
Sub ScratchMacroIII()
Dim oRng As Word.Range
Dim oRngDelete As Word.Range
Set oRng = ActiveDocument.Range
With oRng.Find
  .Text = "Date Filed:"
  While .Execute
    oRng.Select
    Set oRngDelete = ActiveDocument.Bookmarks("\Line").Range
    oRngDelete.Delete
  Wend
End With
End Sub
Sub ScratchMacroIV()
Dim oRng As Word.Range
Dim oRngDelete As Word.Range
Set oRng = ActiveDocument.Range
With oRng.Find
  .Text = "Region Assigned:"
  While .Execute
    oRng.Select
    Set oRngDelete = ActiveDocument.Bookmarks("\Line").Range
    oRngDelete.Delete
  Wend
End With
End Sub
Sub ScratchMacroV()
Dim oRng As Word.Range
Dim oRngDelete As Word.Range
Set oRng = ActiveDocument.Range
With oRng.Find
  .Text = "Reason Closed:"
  While .Execute
    oRng.Select
    Set oRngDelete = ActiveDocument.Bookmarks("\Line").Range
    oRngDelete.Delete
  Wend
End With
End Sub

Sub removeSearchResults()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Search results"
        .Replacement.Text = ""
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    ActiveWindow.ActivePane.VerticalPercentScrolled = 0
End Sub
Sub Clean_Format()
    Selection.WholeStory
    Selection.Style = ActiveDocument.Styles("Normal")
End Sub
Sub insertSpacing()
Dim oRng As Word.Range
Dim oRngDelete As Word.Range
Set oRng = ActiveDocument.Range
With oRng.Find
  .Text = "Case Number"
  While .Execute
    oRng.Select
    Set oRngDelete = ActiveDocument.Bookmarks("\Line").Range
    Selection.MoveEnd Unit:=wdLine, Count:=1
    Selection.InsertParagraphAfter
  Wend
End With
End Sub

Sub insertLineBreak()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Case Number:"
        .Replacement.Text = "<br>Case Number:"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    ActiveWindow.ActivePane.VerticalPercentScrolled = 0
End Sub
Sub KillTheHyperlinks()
Dim oField As Field
For Each oField In ActiveDocument.Fields
If oField.Type = wdFieldHyperlink Then
oField.Unlink
End If
Next
Set oField = Nothing
End Sub

Sub insertParagraphTags()
Selection.WholeStory
nLines = Selection.Range.ComputeStatistics(Statistic:=wdStatisticParagraphs)
Selection.HomeKey Unit:=wdStory
Do While StartNumber2 < nLines
StartNumber2 = StartNumber2 + 1
Selection.HomeKey Unit:=wdLine
Selection.MoveDown Unit:=wdParagraph, Count:=1, Extend:=wdExtend
If InStr(Selection, "Case Number") > 0 Then
Selection.MoveDown Unit:=wdParagraph, Count:=1
Else: Selection.InsertBefore ("</p><p>")
Selection.MoveDown Unit:=wdParagraph, Count:=1
End If
Loop
End Sub

Sub DeleteBlanks()
ActiveDocument.Select
With Selection.Find
    .Text = "^p^p"
    .Replacement.Text = "^p"
    .Execute Replace:=wdReplaceAll, Forward:=True, _
        Wrap:=wdFindContinue
End With
End Sub
Sub DeletePageBreaks()
ActiveSheet.ResetAllPageBreaks
End Sub
Sub LLC_CleanUp()

    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "llc"
        .Replacement.Text = "LLC"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "llc."
        .Replacement.Text = "LLC"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "LLC."
        .Replacement.Text = "LLC"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Llc"
        .Replacement.Text = "LLC"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub

Sub USA_CleanUp()

    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "usa"
        .Replacement.Text = "USA"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Usa"
        .Replacement.Text = "USA"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "USa"
        .Replacement.Text = "USA"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "U.S."
        .Replacement.Text = "United States"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub
Sub Inc_CleanUp()

    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "inc"
        .Replacement.Text = "Inc"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Inc."
        .Replacement.Text = "Inc"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Inc."
        .Replacement.Text = "Inc"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "INC."
        .Replacement.Text = "Inc"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
       With Selection.Find
        .Text = "Inc"
        .Replacement.Text = "Inc"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
       With Selection.Find
        .Text = "INC"
        .Replacement.Text = "Inc"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
      With Selection.Find
        .Text = "Inc"
        .Replacement.Text = "Inc."
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub
Sub dba_CleanUp()

    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting

    With Selection.Find
        .Text = "dba"
        .Replacement.Text = "d/b/a"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "DBA"
        .Replacement.Text = "d/b/a"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
     Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "DBA"
        .Replacement.Text = "D/B/A"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "D.B.A"
        .Replacement.Text = "d/b/a"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "D/B/A"
        .Replacement.Text = "d/b/a"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "d/ba"
        .Replacement.Text = "d/b/a"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "db/a"
        .Replacement.Text = "d/b/a"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Dba"
        .Replacement.Text = "d/b/a"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub
Sub UAW_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "uaw"
        .Replacement.Text = "UAW"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Uaw"
        .Replacement.Text = "UAW"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub
Sub Capital_First_Letter()

Selection.WholeStory
nLines = Selection.Range.ComputeStatistics(Statistic:=wdStatisticParagraphs)
Selection.HomeKey Unit:=wdStory
Do While StartNumber2 < nLines
StartNumber2 = StartNumber2 + 1
Selection.HomeKey Unit:=wdLine
Selection.MoveDown Unit:=wdParagraph, Count:=1, Extend:=wdExtend
If InStr(Selection, "Case Number") > 0 Then
Selection.MoveDown Unit:=wdParagraph, Count:=1
Else: Selection.Range.Case = wdTitleWord
Selection.MoveDown Unit:=wdParagraph, Count:=1
End If
Loop
End Sub
Sub AFL_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "afl-cio"
        .Replacement.Text = "AFL-CIO"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Afl-cio"
        .Replacement.Text = "AFL-CIO"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "Afl-Cio"
        .Replacement.Text = "AFL-CIO"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub
Sub of_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Of"
        .Replacement.Text = "of"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "OF"
        .Replacement.Text = "of"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "oF"
        .Replacement.Text = "of"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub

Sub and_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "And"
        .Replacement.Text = "and"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "AND"
        .Replacement.Text = "and"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub

Sub NYU_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Nyu"
        .Replacement.Text = "NYU"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    Sub Del_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Del"
        .Replacement.Text = "del"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    Sub Ufcw_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Ufcw"
        .Replacement.Text = "UFCW"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    Sub ela_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Ela"
        .Replacement.Text = "ELA"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
     Sub De_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "De"
        .Replacement.Text = "de"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
     Sub Yp_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Yp"
        .Replacement.Text = "YP"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
     Sub Qcd_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Qcd"
        .Replacement.Text = "QCD"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    Sub Mv_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Mv"
        .Replacement.Text = "MV"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    Sub RDB_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Rdb"
        .Replacement.Text = "RDB"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Yrc_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Yrc"
        .Replacement.Text = "YRC"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    Sub Ups_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Ups"
        .Replacement.Text = "UPS"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Cns_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Cns"
        .Replacement.Text = "CNS"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    Sub Lis_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Lis"
        .Replacement.Text = "LIS"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Abm_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Abm"
        .Replacement.Text = "ABM"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Csi_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Csi"
        .Replacement.Text = "CSI"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Ge_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Ge"
        .Replacement.Text = "GE"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Att_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "At & T"
        .Replacement.Text = "AT&T"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub The_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "The"
        .Replacement.Text = "the"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Unite_Here_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Unite Here"
        .Replacement.Text = "UNITE HERE!"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Hms_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Hms"
        .Replacement.Text = "HMS"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
    Sub Seiu_CleanUp()
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "Seiu"
        .Replacement.Text = "SEIU"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = True
        .MatchWholeWord = True
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    End Sub
    
Sub Completed()
    
MsgBox ("Completed")
    
End Sub

Sub A_NLRB_CleanUp()
Call DeleteBlanks
Call Clean_Format
Call Clean_Format
Call Clean_Format
Call removeSearchResults
Call ScratchMacroI
Call ScratchMacroII
Call ScratchMacroIII
Call ScratchMacroIV
Call ScratchMacroV
Call KillTheHyperlinks
Call DeleteBlanks
Call Clean_Format
Call DeleteBlanks
Call Clean_Format
Call DeleteBlanks
Call insertParagraphTags
Call insertSpacing
Call insertLineBreak
Call LLC_CleanUp
Call of_CleanUp
Call AFL_CleanUp
Call UAW_CleanUp
Call dba_CleanUp
Call Inc_CleanUp
Call USA_CleanUp
Call LLC_CleanUp
Call and_CleanUp
Call Ufcw_CleanUp
Call NYU_CleanUp
Call Del_CleanUp
Call ela_CleanUp
Call De_CleanUp
Call Yp_CleanUp
Call Qcd_CleanUp
Call Yrc_CleanUp
Call Ups_CleanUp
Call Cns_CleanUp
Call Lis_CleanUp
Call Abm_CleanUp
Call Csi_CleanUp
Call Ge_CleanUp
Call Att_CleanUp
Call The_CleanUp
Call Hms_CleanUp
Call Seiu_CleanUp
Call Unite_Here_CleanUp
Call Completed
End Sub









