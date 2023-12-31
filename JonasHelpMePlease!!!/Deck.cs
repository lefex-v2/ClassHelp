﻿// comment

class Deck
{
    public List<Cards> deck = new List<Cards>() { new Cards("2Heart", 2, "H"), new Cards("3Heart", 3, "H"), new Cards("4Heart", 4, "H"), new Cards("5Heart", 5, "H"), new Cards("6Heart", 6, "H"), new Cards("7Heart", 7, "H"), new Cards("8Heart", 8, "H"), new Cards("9Heart", 9, "H"), new Cards("10Heart", 10, "H"), new Cards("JHeart", 11, "H"), new Cards("QHeart", 12, "H"), new Cards("KHeart", 13, "H"), new Cards("AHeart", 14, "H"), new Cards("2Diamond", 2, "D"), new Cards("3Diamond", 3, "D"), new Cards("4Diamond", 4, "D"), new Cards("5Diamond", 5, "D"), new Cards("6Diamond", 6, "D"), new Cards("7Diamond", 7, "D"), new Cards("8Diamond", 8, "D"), new Cards("8Diamond", 8, "D"), new Cards("9Diamond", 9, "D"), new Cards("10Diamond", 10, "D"), new Cards("JDiamond", 11, "D"), new Cards("QDiamond", 12, "D"), new Cards("KDiamond", 13, "D"), new Cards("ADiamond", 14, "D"), new Cards("2Clubs", 2, "C"), new Cards("3Clubs", 3, "C"), new Cards("4Clubs", 4, "C"), new Cards("5Clubs", 5, "C"), new Cards("6Clubs", 6, "C"), new Cards("7Clubs", 7, "C"), new Cards("8Clubs", 8, "C"), new Cards("9Clubs", 9, "C"), new Cards("10Clubs", 10, "C"), new Cards("JClubs", 11, "C"), new Cards("QClubs", 12, "C"), new Cards("KClubs", 13, "C"), new Cards("AClubs", 14, "C"), new Cards("2Spades", 2, "S"), new Cards("3Spades", 3, "S"), new Cards("4Spades", 4, "S"), new Cards("5Spades", 5, "S"), new Cards("6Spades", 6, "S"), new Cards("7Spades", 7, "S"), new Cards("8Spades", 8, "S"), new Cards("9Spades", 9, "S"), new Cards("10Spades", 10, "S"), new Cards("JSpades", 11, "S"), new Cards("QSpades", 12, "S"), new Cards("KSpades", 13, "S"), new Cards("ASpades", 14, "S") };

    public void ShuffleDeck()
    {
        deck = deck.OrderBy(a => Random.Shared.Next()).ToList();
    }
}