
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IVotoTorneoRepository
{
void setSessionCP (GenericSessionCP session);

VotoTorneoEN ReadOIDDefault (int id
                             );

void ModifyDefault (VotoTorneoEN votoTorneo);

System.Collections.Generic.IList<VotoTorneoEN> ReadAllDefault (int first, int size);



int New_ (VotoTorneoEN votoTorneo);

void Modify (VotoTorneoEN votoTorneo);


void Destroy (int id
              );


VotoTorneoEN ReadOID (int id
                      );


System.Collections.Generic.IList<VotoTorneoEN> ReadAll (int first, int size);
}
}
