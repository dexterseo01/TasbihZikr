﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace TasbihZikr
{
    public partial class AsmaulHusna : PhoneApplicationPage
    {
        public AsmaulHusna()
        {
            InitializeComponent();
            List<string> temp = new List<string>();
            temp.Add("1 Allah  The Greatest Name");
            temp.Add("2 Ar-Rahman  The All-Compassionate");
            temp.Add("3 Ar-Rahim  The All-Merciful");
            temp.Add("4 Al-Malik  The Absolute Ruler");
            temp.Add("5 Al-Quddus  The Pure One");
            temp.Add("6 As-Salam  The Source of Peace");
            temp.Add("7 Al-Mu'min  The Inspirer of Faith");
            temp.Add("8 Al-Muhaymin  The Guardian");
            temp.Add("9 Al-Aziz  The Victorious");
            temp.Add("10 Al-Jabbar   The Compeller");
            temp.Add("11 Al-Mutakabbir  The Greatest");
            temp.Add("12 Al-Khaliq  The Creator");
            temp.Add("13 Al-Bari'  The Maker of Order");
            temp.Add("14 Al-Musawwir  The Shaper of Beauty");
            temp.Add("15 Al-Ghaffar  The Forgiving");
            temp.Add("16 Al-Qahhar  The Subduer");
            temp.Add("17 Al-Wahhab  The Giver of All");
            temp.Add("18 Ar-Razzaq  The Sustainer");
            temp.Add("19 Al-Fattah  The Opener");
            temp.Add("20 Al-`Alim  The Knower of All");
            temp.Add("21 Al-Qabid  The Constrictor");
            temp.Add("22 Al-Basit  The Reliever");
            temp.Add("23 Al-Khafid  The Abaser");
            temp.Add("24 Ar-Rafi  The Exalter");
            temp.Add("25 Al-Mu'izz  The Bestower of Honors");
            temp.Add("26 Al-Mudhill  The Humiliator");
            temp.Add("27 As-Sami  The Hearer of All");
            temp.Add("28 Al-Basir  The Seer of All");
            temp.Add("29 Al-Hakam  The Judge");
            temp.Add("30 Al-`Adl  The Just");
            temp.Add("31 Al-Latif  The Subtle One");
            temp.Add("32 Al-Khabir  The All-Aware");
            temp.Add("33 Al-Halim  The Forbearing");
            temp.Add("34 Al-Azim  The Magnificent");
            temp.Add("35 Al-Ghafur  The Forgiver and Hider of Faults");
            temp.Add("36 Ash-Shakur  The Rewarder of Thankfulness");
            temp.Add("37 Al-Ali   The Highest");
            temp.Add("38 Al-Kabir  The Greatest");
            temp.Add("39 Al-Hafiz  The Preserver");
            temp.Add("40 Al-Muqit  The Nourisher");
            temp.Add("41 Al-Hasib  The Accounter");
            temp.Add("42 Al-Jalil  The Mighty");
            temp.Add("43 Al-Karim  The Generous");
            temp.Add("44 Ar-Raqib  The Watchful One");
            temp.Add("45 Al-Mujib  The Responder to Prayer");
            temp.Add("46 Al-Wasi  The All-Comprehending");
            temp.Add("47 Al-Hakim  The Perfectly Wise");
            temp.Add("48 Al-Wadud  The Loving One");
            temp.Add("49 Al-Majid  The Majestic One");
            temp.Add("50 Al-Ba'ith   The Resurrector");
            temp.Add("51 Ash-Shahid  The Witness");
            temp.Add("52 Al-Haqq  The Truth");
            temp.Add("53 Al-Wakil  The Trustee");
            temp.Add("54 Al-Qawiyy  The Possessor of All Strength");
            temp.Add("55 Al-Matin  The Forceful One");
            temp.Add("56 Al-Waliyy   The Governor");
            temp.Add("57 Al-Hamid  The Praised One");
            temp.Add("58 Al-Muhsi  The Appraiser");
            temp.Add("59 Al-Mubdi'  The Originator");
            temp.Add("60 Al-Mu'id  The Restorer");
            temp.Add("61 Al-Muhyi  The Giver of Life");
            temp.Add("62 Al-Mumit   The Taker of Life");
            temp.Add("63 Al-Hayy  The Ever Living One");
            temp.Add("64 Al-Qayyum  The Self-Existing One");
            temp.Add("65 Al-Wajid  The Finder");
            temp.Add("66 Al-Majid   The Glorious");
            temp.Add("67 Al-Wahid  The One, the All Inclusive, The Indivisible");
            temp.Add("68 As-Samad  The Satisfier of All Needs");
            temp.Add("69 Al-Qadir  The All Powerful");
            temp.Add("70 Al-Muqtadir  The Creator of All Power");
            temp.Add("71 Al-Muqaddim  The Expediter");
            temp.Add("72 Al-Mu'akhkhir  The Delayer");
            temp.Add("73 Al-Awwal  The First");
            temp.Add("74 Al-Akhir   The Last");
            temp.Add("75 Az-Zahir  The Manifest One");
            temp.Add("76 Al-Batin  The Hidden One");
            temp.Add("77 Al-Wali  The Protecting Friend");
            temp.Add("78 Al-Muta'ali  The Supreme One");
            temp.Add("79 Al-Barr  The Doer of Good");
            temp.Add("80 At-Tawwab   The Guide to Repentance");
            temp.Add("81 Al-Muntaqim  The Avenger");
            temp.Add("82 Al-'Afuww   The Forgiver");
            temp.Add("83 Ar-Ra'uf  The Clement");
            temp.Add("84 Malik-al-Mulk  The Owner of All");
            temp.Add("85 Dhu-al-Jalal wa-al-Ikram  The Lord of Majesty & Bounty");
            temp.Add("86 Al-Muqsit  The Equitable One");
            temp.Add("87 Al-Jami'  The Gatherer");
            temp.Add("88 Al-Ghani  The Rich One");
            temp.Add("89 Al-Mughni  The Enricher");
            temp.Add("90 Al-Mani' The Preventer of Harm");
            temp.Add("91 Ad-Darr  The Creator of The Harmful");
            temp.Add("92 An-Nafi' The Creator of Good");
            temp.Add("93 An-Nur  The Light");
            temp.Add("94 Al-Hadi  The Guide");
            temp.Add("95 Al-Badi  The Originator");
            temp.Add("96 Al-Baqi   The Everlasting One");
            temp.Add("97 Al-Warith  The Inheritor of All");
            temp.Add("98 Ar-Rashid  The Righteous Teacher");
            temp.Add("99 As-Sabur  The Patient One");
            namesAllah.ItemsSource = temp;
        }
    }
}