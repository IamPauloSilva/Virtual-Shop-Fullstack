﻿using System.ComponentModel.DataAnnotations;

namespace VShop.DiscountApi.DTOs;

public class CouponDTO
{
    public int CouponId { get; set; }
    
    public string? CouponCode { get; set; }
    [Required]
    public decimal Discount { get; set; }
}
