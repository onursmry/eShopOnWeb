﻿using System;
using System.Collections.Generic;
using BlazorShared.Enums;
using Microsoft.eShopWeb.PublicApi.OrderDetailEndpoints;

namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

public class OrderDto
{
    public int Id { get; set; }
    public string BuyerId { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public List<OrderItemDto> OrderItems { get; set; }
    public decimal Total { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
