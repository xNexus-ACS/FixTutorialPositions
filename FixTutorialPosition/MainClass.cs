using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using UnityEngine;

namespace FixTutorialPosition
{
    public class MainClass : Plugin<Config>
    {
        public override string Author { get; } = "xNexusACS";
        public override string Name { get; } = "FixTutorialPosition";
        public override string Prefix { get; } = "FixTutorialPosition";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);
        
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole += OnChangingRole;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= OnChangingRole;
            base.OnDisabled();
        }

        private void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole is RoleTypeId.Tutorial)
                ev.Player.Position = new Vector3(40.297f, 1014.110f, -31.918f);
        }
    }
}