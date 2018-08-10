using BrawlLib.SSBB.Types;
using System;
using System.ComponentModel;
using System.Linq;

namespace BrawlLib.SSBB.ResourceNodes
{
    public unsafe class AllstarDifficultyNode : ResourceNode
    {
        private AllstarDifficultyData data;

        public byte Unknown00 { get { return data._unknown00; } set { data._unknown00 = value; SignalPropertyChange(); } }
        public byte Unknown01 { get { return data._unknown01; } set { data._unknown01 = value; SignalPropertyChange(); } }
        public byte Unknown02 { get { return data._unknown02; } set { data._unknown02 = value; SignalPropertyChange(); } }
        public byte Unknown03 { get { return data._unknown03; } set { data._unknown03 = value; SignalPropertyChange(); } }

        public short OffenseRatio { get { return data._offenseRatio; } set { data._offenseRatio = value; SignalPropertyChange(); } }
        public short DefenseRatio { get { return data._defenseRatio; } set { data._defenseRatio = value; SignalPropertyChange(); } }

        public byte Unknown08 { get { return data._unknown08; } set { data._unknown08 = value; SignalPropertyChange(); } }
        public byte Color { get { return data._color; } set { data._color = value; SignalPropertyChange(); } }
        public byte Stock { get { return data._stock; } set { data._stock = value; SignalPropertyChange(); } }
        public byte Unknown0b { get { return data._unknown0b; } set { data._unknown0b = value; SignalPropertyChange(); } }

        public short Unknown0c { get { return data._unknown0c; } set { data._unknown0c = value; SignalPropertyChange(); } }

        public override bool OnInitialize()
        {
            base.OnInitialize();

            if (WorkingUncompressed.Length != sizeof(AllstarDifficultyData))
                throw new Exception("Wrong size for AllstarDifficultyNode");

            // Copy the data from the address
            data = *(AllstarDifficultyData*)WorkingUncompressed.Address;

            return false;
        }
        public override void OnRebuild(VoidPtr address, int length, bool force)
        {
            // Copy the data back to the address
            *(AllstarDifficultyData*)address = data;
        }
        public override int OnCalculateSize(bool force)
        {
            return sizeof(AllstarDifficultyData);
        }
    }

    public unsafe class AllstarFighterNode : ResourceNode
    {
        private byte _fighterID, _unknown01, _unknown02, _unknown03;
        private float _unknown04;

        [TypeConverter(typeof(DropDownListFighterIDs))]
        public byte FighterID { get { return _fighterID; } set { _fighterID = value; Name = BrawlLib.StageBox.FighterNameGenerators.FromID(_fighterID, BrawlLib.StageBox.FighterNameGenerators.slotIDIndex, "-S"); SignalPropertyChange(); } }
        public float Unknown04 { get { return _unknown04; } set { _unknown04 = value; SignalPropertyChange(); } }

        public override bool OnInitialize()
        {
            base.OnInitialize();

            if (WorkingUncompressed.Length != sizeof(AllstarFighterData))
                throw new Exception("Wrong size for AllstarFighterNode");

            // Copy the data from the address
            AllstarFighterData* ptr = (AllstarFighterData*)WorkingUncompressed.Address;
            _fighterID = ptr->_fighterID;
            _unknown01 = ptr->_unknown01;
            _unknown02 = ptr->_unknown02;
            _unknown03 = ptr->_unknown03;
            _unknown04 = ptr->_unknown04;

            if (_name == null)
                _name = BrawlLib.StageBox.FighterNameGenerators.FromID(_fighterID, BrawlLib.StageBox.FighterNameGenerators.slotIDIndex, "-S");

            return true;
        }

        public override void OnPopulate()
        {
            VoidPtr ptr = WorkingUncompressed.Address + 8;
            foreach (string s in new string[] { "Easy", "Normal", "Hard", "Very Hard", "Intense" })
            {
                DataSource source = new DataSource(ptr, sizeof(AllstarDifficultyData));
                var node = new AllstarDifficultyNode();
                node.Initialize(this, source);
                node.Name = s;
                node.IsDirty = false;
                ptr += sizeof(AllstarDifficultyData);
            }
        }

        public override void OnRebuild(VoidPtr address, int length, bool force)
        {
            // Copy the data back to the address
            AllstarFighterData* header_ptr = (AllstarFighterData*)address;
            header_ptr->_fighterID = _fighterID;
            header_ptr->_unknown01 = _unknown01;
            header_ptr->_unknown02 = _unknown02;
            header_ptr->_unknown03 = _unknown03;
            header_ptr->_unknown04 = _unknown04;

            // Rebuild children using new address
            VoidPtr ptr = address + 8;
            for (int i = 0; i < Children.Count; i++)
            {
                Children[i].Rebuild(ptr, sizeof(AllstarDifficultyData), true);
                ptr += sizeof(AllstarDifficultyData);
            }
        }

        public override int OnCalculateSize(bool force)
        {
            return sizeof(AllstarFighterData);
        }
    }

    public unsafe class AllstarStageTblNode : ResourceNode
    {
        private int _stage1, _stage2, _stage3, _stage4, _stage5;

        public override ResourceType ResourceType { get { return ResourceType.Container; } }

        [TypeConverter(typeof(DropDownListStageIDs))]
        public int Stage1 { get { return _stage1; } set { _stage1 = value; SignalPropertyChange(); } }
        [TypeConverter(typeof(DropDownListStageIDs))]
        public int Stage2 { get { return _stage2; } set { _stage2 = value; SignalPropertyChange(); } }
        [TypeConverter(typeof(DropDownListStageIDs))]
        public int Stage3 { get { return _stage3; } set { _stage3 = value; SignalPropertyChange(); } }
        [TypeConverter(typeof(DropDownListStageIDs))]
        public int Stage4 { get { return _stage4; } set { _stage4 = value; SignalPropertyChange(); } }
        [TypeConverter(typeof(DropDownListStageIDs))]
        public int Stage5 { get { return _stage5; } set { _stage5 = value; SignalPropertyChange(); } }

        public override bool OnInitialize()
        {
            base.OnInitialize();

            // Copy the data from the address
            AllstarStageTbl* dataPtr = (AllstarStageTbl*)WorkingUncompressed.Address;
            _stage1 = dataPtr->_stage1;
            _stage2 = dataPtr->_stage2;
            _stage3 = dataPtr->_stage3;
            _stage4 = dataPtr->_stage4;
            _stage5 = dataPtr->_stage5;

            return true;
        }

        public override void OnPopulate()
        {
            AllstarFighterData* ptr = &((AllstarStageTbl*)WorkingUncompressed.Address)->_opponent1;
            for (int i = 0; i < 5; i++)
            {
                DataSource source = new DataSource(ptr, sizeof(AllstarFighterData));
                new AllstarFighterNode().Initialize(this, source);
                ptr++;
            }
        }

        public override void OnRebuild(VoidPtr address, int length, bool force)
        {
            // Copy the data back to the address
            AllstarStageTbl* dataPtr = (AllstarStageTbl*)address;
            dataPtr->_stage1 = _stage1;
            dataPtr->_stage2 = _stage2;
            dataPtr->_stage3 = _stage3;
            dataPtr->_stage4 = _stage4;
            dataPtr->_stage5 = _stage5;

            // Rebuild children using new address
            AllstarFighterData* ptr = &((AllstarStageTbl*)address)->_opponent1;
            for (int i = 0; i < Children.Count; i++)
            {
                Children[i].Rebuild(ptr, sizeof(AllstarFighterData), true);
                ptr++;
            }
        }
        public override int OnCalculateSize(bool force)
        {
            return sizeof(AllstarStageTbl);
        }
    }
}