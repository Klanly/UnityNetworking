using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.Networking;

public class NetworkedPlayerCharacter : ThirdPersonCharacter {
  NetworkIdentity identity;

  public override void Start() {
    base.Start();

    if(identity == null) {
      identity = GetComponent<NetworkIdentity>();
    }
  }

  public override void Move(Vector3 move, bool crouch, bool jump) {
    if(identity.isLocalPlayer) {
      base.Move(move, crouch, jump);
    }
  }
}
