
using System;
using NeuralPlayGen.ApplicationCore.EN.NeuralPlay;
using NeuralPlayGen.ApplicationCore.CP.NeuralPlay;

namespace NeuralPlayGen.ApplicationCore.IRepository.NeuralPlay
{
public partial interface IComunidadRepository
{
void setSessionCP (GenericSessionCP session);

ComunidadEN ReadOIDDefault (int id
                            );

void ModifyDefault (ComunidadEN comunidad);

System.Collections.Generic.IList<ComunidadEN> ReadAllDefault (int first, int size);



int New_ (ComunidadEN comunidad);

void Modify (ComunidadEN comunidad);


void Destroy (int id
              );


ComunidadEN ReadOID (int id
                     );


System.Collections.Generic.IList<ComunidadEN> ReadAll (int first, int size);
}
}
