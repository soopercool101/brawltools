﻿using System;
using BrawlLib.SSBBTypes;
using System.ComponentModel;
using System.IO;
using System.BrawlEx;

namespace BrawlLib.SSBB.ResourceNodes
{
    public unsafe class MasqueradeNode : ResourceNode
    {
        internal VoidPtr Header { get { return WorkingUncompressed.Address; } }
        public override ResourceType ResourceType { get { return ResourceType.MASQ; } }
        
        public byte _cosmeticSlot; // Recieved from filename since it isn't referenced internally
        public static readonly byte Size = 0x66;

        public static readonly string[] MasqueradeIDs =
        {
            "00 - Mario",
            "01 - Donkey Kong",
            "02 - Link",
            "03 - Samus",
            "04 - Zero Suit Samus",
            "05 - Yoshi",
            "06 - Kirby",
            "07 - Fox",
            "08 - Pikachu",
            "09 - Luigi",
            "10 - Captain Falcon",
            "11 - Ness",
            "12 - Bowser / Giga Bowser",
            "13 - Peach",
            "14 - Zelda",
            "15 - Sheik",
            "16 - Ice Climbers",
            "17 - Marth",
            "18 - Mr. Game & Watch",
            "19 - Falco",
            "20 - Ganondorf",
            "21 - Wario / Wario-Man",
            "22 - Meta Knight",
            "23 - Pit",
            "24 - Olimar",
            "25 - Lucas",
            "26 - Diddy Kong",
            "27 - Pokemon Trainer",
            "28 - Charizard",
            "29 - Squirtle",
            "30 - Ivysaur",
            "31 - King Dedede",
            "32 - Lucario",
            "33 - Ike",
            "34 - R.O.B.",
            "35 - Jigglypuff",
            "36 - Toon Link",
            "37 - Wolf",
            "38 - Snake",
            "39 - Sonic",
            "40 - Mewtwo",
            "41 - Roy"
        };

        public static readonly string[] MasqueradeInternalNames =
        {
            "Mario",
            "Donkey",
            "Link",
            "Samus",
            "SZerosuit",
            "Yoshi",
            "Kirby",
            "Fox",
            "Pikachu",
            "Luigi",
            "Captain",
            "Ness",
            "Koopa/GKoopa",
            "Peach",
            "Zelda",
            "Sheik",
            "Popo",
            "Marth",
            "GameWatch",
            "Falco",
            "Ganon",
            "Wario/WarioMan",
            "Metaknight",
            "Pit",
            "Pikmin",
            "Lucas",
            "Diddy",
            "PokeTrainer",
            "PokeLizardon",
            "PokeZenigame",
            "PokeFushigisou",
            "Dedede",
            "Lucario",
            "Ike",
            "Robot",
            "Purin",
            "ToonLink",
            "Wolf",
            "Snake",
            "Sonic",
            "Mewtwo",
            "Roy"
        };

        public override void OnPopulate()
        {
            MasqueradeEntryNode end = new MasqueradeEntryNode(true);
            for (int i = 0; i < MasqueradeNode.Size; i++)
            {
                new MasqueradeEntryNode().Initialize(this, new DataSource((Header)[i, 2], 2));
                MasqueradeEntryNode m = (MasqueradeEntryNode)Children[Children.Count - 1];
                if (m.Color == end.Color && m.CostumeID == end.CostumeID)
                {
                    RemoveChild(m);
                    _changed = false;
                    break;
                }
            }
        }

        public override void OnRebuild(VoidPtr address, int length, bool force)
        {
            uint offset = (uint)(0x00);
            for (int i = 0; i < Children.Count; i++)
            {
                // Ensure Wario's Costume isn't put in a corrupted ID
                if (_cosmeticSlot == 21 && (
                    offset == 0x0F ||
                    offset == 0x1F ||
                    offset == 0x2F ||
                    offset == 0x3F
                    ))
                {
                    MasqueradeEntryNode blank = new MasqueradeEntryNode(false);
                    blank.Rebuild((VoidPtr)address + offset, 2, true);
                    offset += 2;
                }
                else
                {
                    ResourceNode r = Children[i];
                    r.Rebuild((VoidPtr)address + offset, 2, true);
                    offset += 2;
                }
            }
            // Ensure Wario's End Slot isn't put in a corrupted ID
            if(_cosmeticSlot == 21 && (
                    offset == 0x0F ||
                    offset == 0x1F ||
                    offset == 0x2F ||
                    offset == 0x3F))
            {
                MasqueradeEntryNode blank = new MasqueradeEntryNode(false);
                blank.Rebuild((VoidPtr)address + offset, 2, true);
                offset += 2;
            }
            MasqueradeEntryNode end = new MasqueradeEntryNode(true);
            end.Rebuild((VoidPtr)address + offset, 2, true);
            offset += 2;
            while (offset < Size)
            {
                MasqueradeEntryNode blank = new MasqueradeEntryNode(false);
                blank.Rebuild((VoidPtr)address + offset, 2, true);
                offset += 2;
            }
        }

        public override int OnCalculateSize(bool force, bool rebuilding = true)
        {
            return MasqueradeNode.Size;
        }

        public override bool OnInitialize()
        {
            byte.TryParse(Path.GetFileNameWithoutExtension(_origPath), out _cosmeticSlot);
            if ((_name == null) && (_origPath != null))
                _name = MasqueradeIDs[_cosmeticSlot];
            return true;
        }
    }

    public unsafe class MasqueradeEntryNode : ResourceNode
    {
        internal CSSCEntry* Header { get { return (CSSCEntry*)WorkingUncompressed.Address; } }
        public override ResourceType ResourceType { get { return ResourceType.Unknown; } }

        public byte _colorID;
        public byte _costumeID;

        public MasqueradeEntryNode()
        {
            _colorID = 0x00;
            _costumeID = 0x00;
        }

        // Defaults to the costume end marker
        public MasqueradeEntryNode(bool end)
        {
            _colorID = (byte)(end ? 0x0C : 0x00);
            _costumeID = 0x00;
        }

        [Category("Costume")]
        [DisplayName("Costume ID")]
        public byte CostumeID
        {
            get
            {
                return _costumeID;
            }
            set
            {
                _costumeID = value;
                regenName();
                SignalPropertyChange();
            }
        }

        [Category("Costume")]
        [TypeConverter(typeof(DropDownListBrawlExColorIDs))]
        [DisplayName("Color")]
        public byte Color
        {
            get
            {
                return _colorID;
            }
            set
            {
                _colorID = value;
                regenName();
                SignalPropertyChange();
            }
        }

        public override int OnCalculateSize(bool force, bool rebuilding = true)
        {
            return CSSCEntry.Size;
        }

        public override bool OnInitialize()
        {
            _colorID = Header->_colorID;
            _costumeID = Header->_costumeID;
            if (_name == null)
                _name = "Fit" + MasqueradeNode.MasqueradeInternalNames[((MasqueradeNode)Parent)._cosmeticSlot] + _costumeID.ToString("00") + (BrawlExColorID.Colors.Length > _colorID ? " - " + BrawlExColorID.Colors[_colorID].Name : "");
            return false;
        }

        public void regenName()
        {
            Name = "Fit" + MasqueradeNode.MasqueradeInternalNames[((MasqueradeNode)Parent)._cosmeticSlot] + _costumeID.ToString("00") + (BrawlExColorID.Colors.Length > _colorID ? " - " + BrawlExColorID.Colors[_colorID].Name : "");
        }

        public override void OnRebuild(VoidPtr address, int length, bool force)
        {
            CSSCEntry* hdr = (CSSCEntry*)address;
            hdr->_colorID = _colorID;
            hdr->_costumeID = _costumeID;
        }
    }
}