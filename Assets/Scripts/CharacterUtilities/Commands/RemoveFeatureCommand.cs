using CharacterUtilities.Features;

namespace CharacterUtilities.Commands
{
    public class RemoveFeatureCommand : IFeatureCommand
    {
        private Character _character;
        private CharacterFeature _feature;
        public RemoveFeatureCommand(Character character, CharacterFeature feature)
        {
            this._character = character;
            this._feature = feature;
        }
        public void Execute()
        {
            _character.gameObject.AddComponent(_feature.GetType());
            _feature.RemoveFeature();
        }
        
    }
}