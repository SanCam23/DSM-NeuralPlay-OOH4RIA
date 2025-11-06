
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IParticipacionTorneoRepository
{
void setSessionCP (GenericSessionCP session);

ParticipacionTorneoEN ReadOIDDefault (int id
                                      );

void ModifyDefault (ParticipacionTorneoEN participacionTorneo);

System.Collections.Generic.IList<ParticipacionTorneoEN> ReadAllDefault (int first, int size);



int New_ (ParticipacionTorneoEN participacionTorneo);

void Modify (ParticipacionTorneoEN participacionTorneo);


void Destroy (int id
              );


ParticipacionTorneoEN ReadOID (int id
                               );


System.Collections.Generic.IList<ParticipacionTorneoEN> ReadAll (int first, int size);
}
}
