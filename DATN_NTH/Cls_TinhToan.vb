Public Class Cls_TinhToan
    '-----Tinh suc chiu tai cua coc theo vat lieu--------
    Function Pvl() As Double
        Dim Fa As Double 'Dien tich be tong
        Dim Fb As Double  ' Dien tich cot thep
        Dim Lctt As Double  'Chieu dai tinh toan coc
        Dim SCT As Double

        Fa = (Coc.Sothanhthep * Coc.DKthep * Coc.DKthep * Math.PI * (10 ^ -6)) / 4
        Fb = Coc.Dc * Coc.Dc - Fa
        Lctt = Coc.Lc - Coc.Lngam
        SCT = Math.Round(0.9 * 1 * (Fb * Coc.Rb + Fa * Coc.Rs), 2)
        Return SCT
    End Function

    '-----Tinh suc chiu tai cua coc theo CPT ------------
    Function Pcpt() As Double
        Dim SCT As Double
        Dim solopdat As Integer

        solopdat = LST_DiaChat.Count - 1
        Dim caotrinh(solopdat) As Double
        caotrinh(0) = 0         'cot 0.00 tai mat dat tu nhien
        For i = 1 To solopdat
            caotrinh(i) = caotrinh(i - 1) + LST_DiaChat(i - 1).ChieuDay
        Next

        '-----Tinh suc khang ma sat Qs o thanh coc (Qs)-----
        Dim Qs As Double
        Dim Qsmui As Double     'suc khang o doan coc trong lop dat cuoi cung
        Dim Qsdaydai As Double   'suc khang o doan coc ngay duoi day dai
        Dim Qsi As Double         'suc khang ma sat o cac lop dat con lai
        Dim Lctt As Double      'chieu dai tinh toan cua coc
        Dim Lmui As Double      'chieu dai doan coc trong lop dat cuoi cung
        Dim Ldd As Double       'chieu dai doan coc ngay duoi day dai
        Dim Li As Double       'chieu dai doan coc o cac lop con lai

        Lctt = Coc.Lc - Coc.Lngam
        For i = 1 To solopdat
            If DaiMong.Hm + Lctt < caotrinh(i) And DaiMong.Hm + Lctt > caotrinh(i - 1) Then
                Lmui = DaiMong.Hm + Lctt - caotrinh(i - 1)
                Qsmui = 4 * Coc.Dc * Lmui * LST_DiaChat(i - 1).Qc / LST_DiaChat(i - 1).Hsa
            End If
        Next

        For i = 1 To solopdat
            If DaiMong.Hm < caotrinh(i) And DaiMong.Hm > caotrinh(i - 1) Then
                Ldd = caotrinh(i) - DaiMong.Hm
                Qsdaydai = 4 * Coc.Dc * Ldd * LST_DiaChat(i - 1).Qc / LST_DiaChat(i - 1).Hsa
            End If
        Next

        Qsi = 0
        For i = 1 To solopdat
            If DaiMong.Hm <= caotrinh(i - 1) And DaiMong.Hm + Lctt > caotrinh(i) Then
                Li = caotrinh(i) - caotrinh(i - 1)
                Qsi = Qsi + 4 * Coc.Dc * Li * LST_DiaChat(i - 1).Qc / LST_DiaChat(i - 1).Hsa
            End If
        Next

        Qs = Qsdaydai + Qsi + Qsmui

        '--------Tinh suc can pha hoai cua dat o mui coc (Qc)--------
        Dim Qc As Double
        For i = 1 To solopdat
            If DaiMong.Hm + Lctt < caotrinh(i) And DaiMong.Hm + Lctt > caotrinh(i - 1) Then
                Qc = LST_DiaChat(i - 1).Hsk * Coc.Dc * Coc.Dc * LST_DiaChat(i - 1).Qc
            End If
        Next

        SCT = Math.Round(((Qs + Qc) / 1.75), 2)

        Return SCT
    End Function

    '-----Tinh suc chiu tai cua coc theo SPT-----------
    Function Pspt() As Double
        Dim SCT As Double
        Dim solopdat As Integer

        solopdat = LST_DiaChat.Count - 1
        Dim caotrinh(solopdat) As Double
        caotrinh(0) = 0         'cot 0.00 tai mat dat tu nhien
        For i = 1 To solopdat
            caotrinh(i) = caotrinh(i - 1) + LST_DiaChat(i - 1).ChieuDay
        Next

        '-----Tinh suc khang ma sat Qs o thanh coc (Qs)-----
        Dim Qs As Double
        Dim Qsmui As Double     'suc khang o doan coc trong lop dat cuoi cung
        Dim Qsdaydai As Double   'suc khang o doan coc ngay duoi day dai
        Dim Qsi As Double         'suc khang ma sat o cac lop dat con lai
        Dim Lctt As Double      'chieu dai tinh toan cua coc
        Dim Lmui As Double      'chieu dai doan coc trong lop dat cuoi cung
        Dim Ldd As Double       'chieu dai doan coc ngay duoi day dai
        Dim Li As Double       'chieu dai doan coc o cac lop con lai

        Lctt = Coc.Lc - Coc.Lngam
        For i = 1 To solopdat
            If DaiMong.Hm + Lctt < caotrinh(i) And DaiMong.Hm + Lctt > caotrinh(i - 1) Then
                Lmui = DaiMong.Hm + Lctt - caotrinh(i - 1)
                Qsmui = 2 * 4 * Coc.Dc * LST_DiaChat(i - 1).N30 * Lmui
            End If
        Next

        For i = 1 To solopdat
            If DaiMong.Hm < caotrinh(i) And DaiMong.Hm > caotrinh(i - 1) Then
                Ldd = caotrinh(i) - DaiMong.Hm
                Qsdaydai = 2 * 4 * Coc.Dc * LST_DiaChat(i - 1).N30 * Ldd
            End If
        Next

        Qsi = 0
        For i = 1 To solopdat
            If DaiMong.Hm <= caotrinh(i - 1) And DaiMong.Hm + Lctt > caotrinh(i) Then
                Li = caotrinh(i) - caotrinh(i - 1)
                Qsi = Qsi + 2 * 4 * Coc.Dc * LST_DiaChat(i - 1).N30 * Li
            End If
        Next

        Qs = Qsdaydai + Qsi + Qsmui

        '--------Tinh suc can pha hoai cua dat o mui coc (Qc)--------
        Dim Qc As Double
        For i = 1 To solopdat
            If DaiMong.Hm + Lctt < caotrinh(i) And DaiMong.Hm + Lctt > caotrinh(i - 1) Then
                Qc = 400 * LST_DiaChat(i - 1).N30 * Coc.Dc * Coc.Dc
            End If
        Next

        SCT = Math.Round(((Qs + Qc) / 1.75), 2)
        Return SCT
    End Function

    '-----Tinh toan dam thung cua cot ----------
    Function DamThung(k As Integer) As Double
        Dim sococ As Integer
        sococ = LST_Coc.Count

        Dim Pdt As Double
        Dim Pcdt As Double
        Dim c1 As Double
        Dim c2 As Double
        Dim ho As Double
        ho = DaiMong.Hd - 0.1

        '-----tinh c1, c2------
        c1 = (DaiMong.Ld / 2) - (DaiMong.Hcot / 2) - DaiMong.KcCocdenDai - Coc.Dc
        c2 = (DaiMong.Bd / 2) - (DaiMong.Bcot / 2) - DaiMong.KcCocdenDai - Coc.Dc

        If c1 > ho Then
            c1 = ho
        ElseIf c1 < 0.4 * ho Then
            c1 = 0.4 * ho
        End If

        If c2 > ho Then
            c2 = ho
        ElseIf c2 < 0.4 * ho Then
            c2 = 0.4 * ho
        End If

        '-----tinh Pcdt - P chong dam thung----
        Pcdt = 2 * (((DaiMong.Bcot + c2) * ho / c1) + ((DaiMong.Hcot + c1) * ho / c2)) * ho * DaiMong.Rbt

        '-----tinh Pdt - P dam thung-----
        Select Case sococ
            Case 2      'truong hop 2 coc
                Pdt = LST_Coc(0).Poi + LST_Coc(1).Poi
            Case 3
                Pdt = LST_Coc(0).Poi + LST_Coc(2).Poi
            Case 4, 6, 8    'truong hop 4, 6, 8 coc
                Pdt = 0
                For i = 0 To sococ - 1
                    Pdt = Pdt + LST_Coc(i).Poi
                Next
            Case 5      'truong hop 5 coc
                Pdt = LST_Coc(0).Poi + LST_Coc(1).Poi + LST_Coc(3).Poi + LST_Coc(4).Poi
            Case 7      'truong hop 7 coc
                Pdt = LST_Coc(0).Poi + LST_Coc(1).Poi + LST_Coc(2).Poi + LST_Coc(4).Poi + LST_Coc(5).Poi + LST_Coc(6).Poi
        End Select

        If k = 1 Then
            DamThung = Pcdt
        ElseIf k = 2 Then
            DamThung = Pdt
        End If
    End Function

    '-----Tinh toan choc thung theo mat phang nghieng cua coc----------
    Function ChocThung(k As Integer) As Double
        Dim sococ As Integer
        sococ = LST_Coc.Count

        Dim Pct As Double
        Dim Pcct As Double
        Dim c1 As Double
        Dim c2 As Double
        Dim ho As Double
        ho = DaiMong.Hd - 0.1

        '-----tinh c1, c2------
        c1 = (DaiMong.Ld / 2) - (DaiMong.Hcot / 2) - DaiMong.KcCocdenDai - Coc.Dc
        c2 = (DaiMong.Bd / 2) - (DaiMong.Bcot / 2) - DaiMong.KcCocdenDai - Coc.Dc

        If c1 > ho Then
            c1 = ho
        ElseIf c1 < 0.4 * ho Then
            c1 = 0.4 * ho
        End If

        If c2 > ho Then
            c2 = ho
        ElseIf c2 < 0.4 * ho Then
            c2 = 0.4 * ho
        End If

        '-----tinh Pcct - P chong choc thung-----
        Pcct = 1.5 * DaiMong.Bd * ho * DaiMong.Rbt * ho / c1

        '-----tinh Pct - P choc thung cua hang coc xa nhat-----
        Dim Xmax As Double
        Xmax = LST_Coc(0).X
        For i = 0 To sococ - 1
            If Xmax <= LST_Coc(i).X Then
                Xmax = LST_Coc(i).X
            End If
        Next

        Pct = 0
        For i = 0 To sococ - 1
            If LST_Coc(i).X = Xmax Then
                Pct = Pct + LST_Coc(i).Poi
            End If
        Next

        If k = 1 Then
            ChocThung = Pcct
        ElseIf k = 2 Then
            ChocThung = Pct
        End If
    End Function

    '-----Tinh thep dai mong----------
    Function ThepDai(k As Integer)
        Dim Xmepcot As Double
        Dim Ymepcot As Double
        Dim ho As Double
        Xmepcot = DaiMong.Hcot / 2
        Ymepcot = DaiMong.Bcot / 2
        ho = DaiMong.Hd - 0.1

        '-----Tinh thep theo phuong X - Mat cat 1-1------
        Dim As1 As Double
        Dim M1 As Double
        M1 = 0
        For i = 0 To LST_Coc.Count - 1
            If LST_Coc(i).X > Xmepcot Then
                M1 = M1 + LST_Coc(i).Poi * (LST_Coc(i).X - Xmepcot)
            End If
        Next

        As1 = (M1 * 10 ^ 4) / (0.9 * ho * DaiMong.Rs)

        '-----Tinh thep theo phuong y - Mat cat 2-2------
        Dim As2 As Double
        Dim M2 As Double
        M2 = 0
        For i = 0 To LST_Coc.Count - 1
            If LST_Coc(i).Y > Ymepcot Then
                M2 = M2 + LST_Coc(i).Poi * (LST_Coc(i).Y - Ymepcot)
            End If
        Next

        As2 = (M2 * 10 ^ 4) / (0.9 * ho * DaiMong.Rs)

        If k = 1 Then
            ThepDai = Math.Round(As1, 2)
        ElseIf k = 2 Then
            ThepDai = Math.Round(As2, 2)
        End If

    End Function

    '-----Kiem tra coc------------
    Function KiemTraCoc(k As Integer, L As Double)
        Dim Q As Double
        Q = 25 * 1.5 * Coc.Dc * Coc.Dc

        Dim a As Double
        Dim M1 As Double
        a = 0.207 * L
        M1 = Math.Round(Q * a ^ 2 / 2, 2)

        Dim b As Double
        Dim M2 As Double
        b = 0.29 * L
        M2 = Math.Round(Q * b ^ 2 / 2, 2)

        If k = 1 Then
            KiemTraCoc = M1
        ElseIf k = 2 Then
            KiemTraCoc = M2
        End If
    End Function

    '-----Tinh cot thep chiu momen uon trong coc----
    Function ThepCoc(M As Double)
        Dim Fa As Double
        Dim ho As Double

        ho = Coc.Dc - 0.04
        Fa = Math.Round(M * 10 ^ 4 / (0.9 * ho * Coc.Rs), 2)
        Return Fa
    End Function
End Class
