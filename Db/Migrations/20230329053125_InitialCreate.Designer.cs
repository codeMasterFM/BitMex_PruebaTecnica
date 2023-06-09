﻿// <auto-generated />
using System;
using Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Db.Migrations
{
    [DbContext(typeof(BitmexContext))]
    [Migration("20230329053125_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Db.Instrument", b =>
                {
                    b.Property<string>("symbol")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("askPrice")
                        .HasColumnType("real");

                    b.Property<float>("bidPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("calcInterval")
                        .HasColumnType("datetime2");

                    b.Property<bool>("deleverage")
                        .HasColumnType("bit");

                    b.Property<DateTime>("expiry")
                        .HasColumnType("datetime2");

                    b.Property<int>("fairBasis")
                        .HasColumnType("int");

                    b.Property<float>("fairBasisRate")
                        .HasColumnType("real");

                    b.Property<string>("fairMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("fairPrice")
                        .HasColumnType("float");

                    b.Property<int>("foreignNotional24h")
                        .HasColumnType("int");

                    b.Property<DateTime>("front")
                        .HasColumnType("datetime2");

                    b.Property<string>("fundingBaseSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fundingInterval")
                        .HasColumnType("datetime2");

                    b.Property<string>("fundingPremiumSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fundingQuoteSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("fundingRate")
                        .HasColumnType("real");

                    b.Property<DateTime>("fundingTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<bool>("hasLiquidity")
                        .HasColumnType("bit");

                    b.Property<float>("highPrice")
                        .HasColumnType("real");

                    b.Property<int>("homeNotional24h")
                        .HasColumnType("int");

                    b.Property<int>("impactAskPrice")
                        .HasColumnType("int");

                    b.Property<float>("impactBidPrice")
                        .HasColumnType("real");

                    b.Property<int>("impactMidPrice")
                        .HasColumnType("int");

                    b.Property<double>("indicativeSettlePrice")
                        .HasColumnType("float");

                    b.Property<double>("initMargin")
                        .HasColumnType("float");

                    b.Property<bool>("isInverse")
                        .HasColumnType("bit");

                    b.Property<bool>("isQuanto")
                        .HasColumnType("bit");

                    b.Property<int>("lastChangePcnt")
                        .HasColumnType("int");

                    b.Property<double>("lastPrice")
                        .HasColumnType("float");

                    b.Property<double>("lastPriceProtected")
                        .HasColumnType("float");

                    b.Property<string>("lastTickDirection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("limit")
                        .HasColumnType("float");

                    b.Property<double>("limitDownPrice")
                        .HasColumnType("float");

                    b.Property<double>("limitUpPrice")
                        .HasColumnType("float");

                    b.Property<DateTime>("listedSettle")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("listing")
                        .HasColumnType("datetime2");

                    b.Property<int>("lotSize")
                        .HasColumnType("int");

                    b.Property<float>("lowPrice")
                        .HasColumnType("real");

                    b.Property<double>("maintMargin")
                        .HasColumnType("float");

                    b.Property<double>("makerFee")
                        .HasColumnType("float");

                    b.Property<string>("markMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("markPrice")
                        .HasColumnType("float");

                    b.Property<int>("maxOrderQty")
                        .HasColumnType("int");

                    b.Property<int>("maxPrice")
                        .HasColumnType("int");

                    b.Property<float>("midPrice")
                        .HasColumnType("real");

                    b.Property<int>("multiplier")
                        .HasColumnType("int");

                    b.Property<int>("openInterest")
                        .HasColumnType("int");

                    b.Property<int>("openValue")
                        .HasColumnType("int");

                    b.Property<string>("positionCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("prevClosePrice")
                        .HasColumnType("int");

                    b.Property<double>("prevPrice24h")
                        .HasColumnType("float");

                    b.Property<int>("prevTotalTurnover")
                        .HasColumnType("int");

                    b.Property<DateTime>("publishInterval")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("publishTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("quoteCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quoteToSettleMultiplier")
                        .HasColumnType("int");

                    b.Property<DateTime>("rebalanceInterval")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("rebalanceTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("referenceSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("riskLimit")
                        .HasColumnType("bigint");

                    b.Property<long>("riskStep")
                        .HasColumnType("bigint");

                    b.Property<string>("rootSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("settlCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("settle")
                        .HasColumnType("datetime2");

                    b.Property<double>("settledPrice")
                        .HasColumnType("float");

                    b.Property<int>("settledPriceAdjustmentRate")
                        .HasColumnType("int");

                    b.Property<double>("settlementFee")
                        .HasColumnType("float");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("takerFee")
                        .HasColumnType("float");

                    b.Property<bool>("taxed")
                        .HasColumnType("bit");

                    b.Property<double>("tickSize")
                        .HasColumnType("float");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("totalTurnover")
                        .HasColumnType("int");

                    b.Property<int>("totalVolume")
                        .HasColumnType("int");

                    b.Property<int>("turnover")
                        .HasColumnType("int");

                    b.Property<int>("turnover24h")
                        .HasColumnType("int");

                    b.Property<string>("typ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("underlying")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("underlyingSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("underlyingToPositionMultiplier")
                        .HasColumnType("int");

                    b.Property<int>("underlyingToSettleMultiplier")
                        .HasColumnType("int");

                    b.Property<int>("volume")
                        .HasColumnType("int");

                    b.Property<int>("volume24h")
                        .HasColumnType("int");

                    b.Property<float>("vwap")
                        .HasColumnType("real");

                    b.HasKey("symbol");

                    b.ToTable("instruments");
                });
#pragma warning restore 612, 618
        }
    }
}
