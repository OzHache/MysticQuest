using CharacterUtilities.Features;

namespace CharacterUtilities.Commands
{
    public class AddFeatureCommand : IFeatureCommand {
        private readonly Character _character;
        private readonly CharacterFeature _feature;

        public AddFeatureCommand(Character character, CharacterFeature feature) {
            this._character = character;
            this._feature = feature;
        }

        public void Execute() {
            _character.gameObject.AddComponent(_feature.GetType());
            _feature.ApplyFeature();
        }
    }
}