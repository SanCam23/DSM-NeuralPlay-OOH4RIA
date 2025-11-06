
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface ISesionRepository
{
void setSessionCP (GenericSessionCP session);

SesionEN ReadOIDDefault (int id
                         );

void ModifyDefault (SesionEN sesion);

System.Collections.Generic.IList<SesionEN> ReadAllDefault (int first, int size);



int New_ (SesionEN sesion);

void Modify (SesionEN sesion);


void Destroy (int id
              );


SesionEN ReadOID (int id
                  );


System.Collections.Generic.IList<SesionEN> ReadAll (int first, int size);
}
}
