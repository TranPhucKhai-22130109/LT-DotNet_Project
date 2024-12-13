﻿using System;
using System.Collections.Generic;

namespace WebBanLapTop.Data;

public partial class HoaDon
{
    public int Id { get; set; }

    public int? Iddn { get; set; }

    public string? TenDn { get; set; }

    public string? Sdt { get; set; }

    public DateTime? NgayDat { get; set; }

    public string? DiaChiNhan { get; set; }

    public int? TongTien { get; set; }

    public bool? TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual User? IddnNavigation { get; set; }
}
