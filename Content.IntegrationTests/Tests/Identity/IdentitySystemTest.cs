using Content.IntegrationTests.Tests.Interaction;
using Content.Shared.IdentityManagement;
using Content.Shared.IdentityManagement.Components;
using NetCord;
using Robust.Shared.Prototypes;

namespace Content.IntegrationTests.Tests.Identity;

[TestFixture]
[TestOf(typeof(IdentitySystem))]
public sealed class IdentitySystemTest : InteractionTest
{
    [TestPrototypes]
    public string IdentityPrototype = @"
- type: entity
  id: IdentityDummy
  name: Dummy
  components:
  - type: Identity";

    //the entity's IdentityRepresentation is correct
    [Test]
    public async Task ValidateIdentityRepresentation()
    {
        var identityComponent = SEntMan.AddComponent<IdentityComponent>(SPlayer);
        var playerIdentityComponent = Comp<IdentityComponent>(Player);

      // await SpawnTarget(IdentityPrototype);

        Assert.That(playerIdentityComponent.ToString() is "IdentityDummy");

    }
    //the entity's name in the MetaDataComponent is correct
    //both the entity's and the identity entity's GrammarComponent are correct
    //Check all of the above on both server and client to make sure they are networked correctly

}

