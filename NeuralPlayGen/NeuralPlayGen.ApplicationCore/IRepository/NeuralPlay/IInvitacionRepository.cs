
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IInvitacionRepository
{
void setSessionCP (GenericSessionCP session);

InvitacionEN ReadOIDDefault (int id
                             );

void ModifyDefault (InvitacionEN invitacion);

System.Collections.Generic.IList<InvitacionEN> ReadAllDefault (int first, int size);



int New_ (InvitacionEN invitacion);

void Modify (InvitacionEN invitacion);


void Destroy (int id
              );


InvitacionEN ReadOID (int id
                      );


System.Collections.Generic.IList<InvitacionEN> ReadAll (int first, int size);
}
}
