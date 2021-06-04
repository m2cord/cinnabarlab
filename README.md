# Welcome to Cinnabarlab!

Authors:
@BeldorTN: [dcastelberg@GitHub](https://github.com/dcastelberg)
@Krujo: [JonasKru@GitHub](https://github.com/JonasKru)
@NotTheRealOne: <TODO: Add Github Account>

# What is Cinnabarlab?

Cinnabarlab aims to act as your one stop shop for Melee Mewtwo Information. Planned are guides, data, personalized training regiments based on your .slp files and much more!

# Who is creating Cinnabarlab?

Cinnabarlab is developed and maintained by the authors mentioned above. Everyone is able to contribute, though. For more information, join the Melee [Mewtwo Character Discord](https://discord.gg/invite/5cS8eeT)

# Starting and Developing Cinnabarlab
## Requirements
 - Docker
 - Docker Compose
 - npm
 - Vue CLI v3
 - .NET 5 SDK
 - Recommended: WebStorm (IDE for frontend development)
 - Recommended: Visual Studio 2019 (IDE for backend development)

## How to Run an Instance of Cinnabarlab

Follow the instructions to get mkcert: https://github.com/FiloSottile/mkcert

If it's the firt install of mkcert, run

`mkcert -install`

Generate certificate for domain "cinnabarlab.localhost", "cinnabarlab.local" and their sub-domains

`mkcert -cert-file infrastructure/ssl/cert.pem -key-file infrastructure/ssl/key.pem 
"docker.localhost" "*.docker.localhost" "cinnabarlab.local" "*.cinnabarlab.local"`

Replace your backend.env, database.env, frontend.env with the most recent .env.template files configure according to your needs.

run `docker-compose -f docker-compose.yml -f docker-compose.override.yml up` in the root folder of this repository.

After all containers have started up, the frontend is available @ https://cinnabarlab.localhost:443.
