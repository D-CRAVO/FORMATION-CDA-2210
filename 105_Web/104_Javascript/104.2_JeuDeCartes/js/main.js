import{ Cards }from './Cards.js'
import{ Card } from './Card.js'

const app =
{
    data() {
        return {
            title: "Cardgame",
            cards: null

        }
    },

    /*
    mounted() {
        setInterval(() => {
            this.title += "a";
        }, 2000)
    },
    */
   /*
    mounted() {
        setInterval(()=> {
            this.title = this.title.substring(0, this.title.length-1);
        }, 2000)
        
    },
    */

    async mounted() {
        /** @var {Cards} cards */
        this.cards = new Cards('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
        await this.cards.getCards();
        console.log(this.cards);
    },

    computed: {
        async colspan() {
            return this.cards.getFirst().length;
        }
    }
}

//console.log(colspan)

Vue.createApp(app).mount("#app");