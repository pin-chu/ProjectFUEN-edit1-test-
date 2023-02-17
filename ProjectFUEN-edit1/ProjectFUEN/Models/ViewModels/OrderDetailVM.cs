﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using ProjectFUEN.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectFUEN.Models.EFModels;

public partial class OrderDetailVM
{
    

    public int Id { get; set; }
    public int MemberId { get; set; }
    [Display(Name ="訂單日期")]
    public DateTime OrderDate { get; set; }

    [Display(Name = "地址")]
    public string Address { get; set; }
    [Display(Name = "訂單狀態")]
    public int State { get; set; }
    [Display(Name = "會員名稱")]
    public virtual Member Member { get; set; }
    public virtual ICollection<OrderItemVM> OrderItems { get; set; }
}