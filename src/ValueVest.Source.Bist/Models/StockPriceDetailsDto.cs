﻿using System.Text.Json.Serialization;

namespace ValueVest.Source.Bist.Models;

public sealed record StockPriceDetailsDto
{
    [JsonPropertyName("value")]
    public IReadOnlyList<StockPriceDetailsValueDto> Prices { get; init; } = [];
}


public sealed record StockPriceDetailsValueDto
{
    [JsonPropertyName("DOLAR_BAZLI_FIYAT")]
    public decimal Price { get; init; }

    [JsonPropertyName("SERMAYE")]
    public decimal Capital { get; init; }

    [JsonPropertyName("PD_USD")]
    public decimal MarketValue { get; init; }
}