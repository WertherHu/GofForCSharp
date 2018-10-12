﻿namespace DesignPattern.Builder.GameRoleDemo
{
    public class AngelBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.Costume = "白裙";
        }

        public override void BuildFace()
        {
            actor.Face = "漂亮";
        }

        public override void BuildHairStyle()
        {
            actor.HairStyle = "披肩长发";
        }

        public override void BuildSex()
        {
            actor.Sex = "女";
        }

        public override void BuildType()
        {
            actor.Type = "天使";
        }
    }
}
