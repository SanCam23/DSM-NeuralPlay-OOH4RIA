
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IPropuestaTorneoRepository
{
void setSessionCP (GenericSessionCP session);

PropuestaTorneoEN ReadOIDDefault (int id
                                  );

void ModifyDefault (PropuestaTorneoEN propuestaTorneo);

System.Collections.Generic.IList<PropuestaTorneoEN> ReadAllDefault (int first, int size);



int New_ (PropuestaTorneoEN propuestaTorneo);

void Modify (PropuestaTorneoEN propuestaTorneo);


void Destroy (int id
              );


PropuestaTorneoEN ReadOID (int id
                           );


System.Collections.Generic.IList<PropuestaTorneoEN> ReadAll (int first, int size);
}
}
