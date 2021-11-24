﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;


namespace ContViewDemo
{
    [DesignTimeVisible(true)]
    public partial class Card : ContentView
    {
        public static readonly BindableProperty
        CardTitleProperty = BindableProperty.Create(
        nameof(CardTitle),
        typeof(string),
        typeof(Card));
        public static readonly BindableProperty
        CBColorProperty = BindableProperty.Create(
        nameof(CBColor),
        typeof(Color),
        typeof(Card),
        Color.Black);
        public static readonly BindableProperty
        TarColorProperty = BindableProperty.Create(
        nameof(TarColor),
        typeof(Color),
        typeof(Card),
        Color.Black);
        public static readonly BindableProperty
        CardColorProperty = BindableProperty.Create(
        nameof(CardColor),
        typeof(Color),
        typeof(Card),
        Color.White);
        public static readonly BindableProperty
        ColTextProperty = BindableProperty.Create(
        nameof(ColText),
        typeof(Color),
        typeof(Card),
        Color.Red);
        public string CardTitle
        {
            get => (string)GetValue(Card.CardTitleProperty);
            set => SetValue(Card.CardTitleProperty, value);
        }
        public Color CBColor
        {
            get => (Color)GetValue(Card.CBColorProperty);
            set => SetValue(Card.CBColorProperty, value);
        }
        public Color TarColor
        {
            get => (Color)GetValue(Card.TarColorProperty);
            set => SetValue(Card.TarColorProperty, value);
        }
        public Color CardColor
        {
            get => (Color)GetValue(Card.CardColorProperty);
            set => SetValue(Card.CardColorProperty, value);
        }
        public Color ColText
        {
            get => (Color)GetValue(Card.ColTextProperty);
            set => SetValue(Card.ColTextProperty, value);
        }
        public Card()
        {
            InitializeComponent();
        }
    }
}