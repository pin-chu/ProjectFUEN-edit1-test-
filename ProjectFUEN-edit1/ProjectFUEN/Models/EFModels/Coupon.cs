﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using ProjectFUEN.Models.DTOs;
using System;
using System.Collections.Generic;

namespace ProjectFUEN.Models.EFModels
{
    public partial class Coupon
    {
        public Coupon()
        {
            Members = new HashSet<Member>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public int LeastCost { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }

    public static class CouponExts
    {
        public static Coupon ToCoupon(this CouponDto source)
        {
            return new Coupon
            {
                Id = source.Id,
                Code = source.Code,
                Name = source.Name,
                Discount = source.Discount,
                LeastCost = source.LeastCost,
                Count = source.Count,
            };
        }
    }
}