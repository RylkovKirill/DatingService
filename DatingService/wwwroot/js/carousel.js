class Carousel {
    constructor(element, dislike, like) {
        this.board = element;
        console.log(this.board);
        this.dislikeButton = dislike;
        this.likeButton = like;
        this.senderInput = document.getElementById("senderId");
        var senderId = this.senderInput.value;
        console.log(senderId);

        // handle getures
        this.handle();
    }


    handle() {
        // list all cards
        this.cards = this.board.querySelectorAll('.rec-card');



        // get top card
        this.topCard = this.cards[this.cards.length - 1];
        // get next card
        this.nextCard = this.cards[this.cards.length - 2];

        if (this.cards.length > 0) {
            // set default top card position and scale
            this.topCard.style.transform =
                'translateX(-50%) translateY(-50%) rotate(0deg) rotateY(0deg) scale(1)';

            // destroy previous Hammer instance, if present
            if (this.hammer) this.hammer.destroy();

            // listen for pan gesture on top card
            this.hammer = new Hammer(this.topCard);
            this.hammer.add(
                new Hammer.Pan({
                    position: Hammer.position_ALL,
                    threshold: 0
                })
            );

            // pass event data to custom callbacks
            this.hammer.on('tap', e => this.onTap(e));
            this.hammer.on("pan", e => this.onPan(e));
        }
    }

    onTap() {
        // get finger position on top card
        let propX = (e.center.x - e.target.getBoundingClientRect().left) / e.target.clientWidth;

        // get degree of Y rotation (+/-15 degrees)
        let rotateY = 15 * (propX < 0.05 ? -1 : 1);

        // change the transition property
        this.topCard.style.transition = 'transform 100ms ease-out';

        // rotate
        this.topCard.style.transform =
            `translateX(-50%) translateY(-50%) rotate(0deg) rotateY(${rotateY}deg) scale(1)`;

        // wait transition end
        setTimeout(() => {
            // reset transform properties
            this.topCard.style.transform =
                'translateX(-50%) translateY(-50%) rotate(0deg) rotateY(0deg) scale(1)';
        }, 100);
    }

    onPan(e) {
        if (!this.isPanning) {
            this.isPanning = true;

            // remove transition property
            this.topCard.style.transition = null;

            // get starting coordinates
            let style = window.getComputedStyle(this.topCard);
            let mx = style.transform.match(/^matrix\((.+)\)$/);
            this.startPosX = mx ? parseFloat(mx[1].split(', ')[4]) : 0;
            this.startPosY = mx ? parseFloat(mx[1].split(', ')[5]) : 0;

            // get card bounds
            let bounds = this.topCard.getBoundingClientRect();

            // get finger position, top (1) or bottom (-1) of the card
            this.isDraggingFrom = (e.center.y - bounds.top) > this.topCard.clientHeight / 2 ? -1 : 1;
        }

        // calculate new coordinates
        let posX = e.deltaX + this.startPosX;
        let posY = e.deltaY + this.startPosX;

        // get ratio between swiped pixels and the axes
        let propX = e.deltaX / this.board.clientWidth;
        let propY = e.deltaY / this.board.clientHeight;

        // get swipe direction, left (-1) or right (1)
        let dirX = e.deltaX < 0 ? -1 : 1;

        // get degrees of rotation between 0 and +/- 45
        let deg = this.isDraggingFrom * dirX * Math.abs(propX) * 45;

        // calculate scale ratio, between 95 and 100 %
        let scale = (95 + 5 * Math.abs(propX)) / 100;

        // move top card
        this.topCard.style.transform = `translateX(${posX}px) translateY(${posY}px) rotate(${deg}deg) rotateY(0deg) scale(1)`;

        // scale next card
        if (this.nextCard) {
            this.nextCard.style.transform = `translateX(-50%) translateY(-50%) rotate(0deg) scale(${scale})`;
        }

        if (e.isFinal) {
            this.isPanning = false;
            let successful = false;

            // set back transition property
            this.topCard.style.transition = 'transform 200ms ease-out';
            if (this.nextCard)
                this.nextCard.style.transition = 'transform 100ms linear';

            // check threshold
            if (propX > 0.25 && e.direction == Hammer.DIRECTION_RIGHT) {
                successful = true;
                // get right border position
                posX = this.board.clientWidth;
            } else if (propX < -0.25 && e.direction == Hammer.DIRECTION_LEFT) {
                successful = true;
                posX = - (this.board.clientWidth + this.topCard.clientWidth);
            } else if (propY < -0.25 && e.direction == Hammer.DIRECTION_UP) {
                successful = true;
                // get top border position
                posY = - (this.board.clientHeight + this.topCard.clientHeight);
            }

            if (successful) {
                // throw card in the chosen direction

                console.log(this.topCard);
                console.log(receiverId);
                console.log(receiverId[receiverId.length - 1].value);

                console.log(this.board);
                console.log(senderId);
                const item = {
                    receiverId: receiverId[receiverId.length - 1].value,
                    senderId: senderId.value
                };
                console.log(item);
                console.log(senderId);
                const uri = 'api/api';
                fetch(uri, {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(item)
                }).then(response => response.json())
                    .catch(error => console.error(error));
            
                this.topCard.style.transform = `translateX(${posX}px) translateY(${posY}px) rotate(${deg}deg)`;
                if (posX > 0) this.swipeRight();
                else this.swipeLeft();

                // wait transition end
                setTimeout(() => {
                    this.board.removeChild(this.topCard);
                    //this.push();
                    this.handle();
                }, 200);
            } else {
                // reset card position
                this.topCard.style.transform = 'translateX(-50%) translateY(-50%)';
                if (this.nextCard)
                    this.nextCard.style.transform =
                        'translateX(-50%) translateY(-50%) rotate(0deg) rotateY(0deg) scale(0.95)';
            }
        }
    }
    swipeLeft() {
        console.log("Свайп влево");
    }
    swipeRight() {
        console.log("Свайп вправо");
    }

    push() {
        let card = document.createElement('div')
        card.classList.add('card');

        card.style.backgroundImage = "url('https://picsum.photos/320/320/?random=" + Math.round(Math.random() * 1000000) + "')";

        this.board.insertBefore(card, this.board.firstChild);
    }
}

var board = document.querySelector('.rec-card-board');
var dislikeButton = document.getElementById("dislikeButton");
var likeButton = document.getElementById('likeButton');
var carousel = new Carousel(board, dislikeButton, likeButton);
dislikeButton.addEventListener("click", forcedSwipeLeft);
likeButton.addEventListener("click", forcedSwipeRight);
function forcedSwipeLeft() {
    carousel.handle();
    cards = board.querySelectorAll('.rec-card');
    console.log("left");
    console.log(cards);

    // get top card
    topCard = cards[cards.length - 1];
    for (i = 1; i <= 1000; i++) {
        topCard.style.transform = `translateX(${-i}px) translateY(${0}px) rotate(${45 / (1000 - i)}deg)`;

        console.log(i);
    }
    setTimeout(() => {
        board.removeChild(topCard);
        //this.push();
        carousel.handle(board, dislikeButton, likeButton);

    }, 200);
}
function forcedSwipeRight() {
    carousel.handle();
    cards = board.querySelectorAll('.rec-card');
    console.log("left");
    console.log(cards);
    

    // get top card
    topCard = cards[cards.length - 1];
    for (i = 1; i <= 1000; i++) {
        topCard.style.transform = `translateX(${i}px) translateY(${0}px) rotate(${45 / (1000 - i)}deg)`;

        console.log(i);
    }
    setTimeout(() => {
        board.removeChild(topCard);
        //this.push();
        carousel.handle(board, dislikeButton, likeButton);

    }, 200);
}
function sleep(milliseconds) {
    const date = Date.now();
    let currentDate = null;
    do {
        currentDate = Date.now();
    } while (currentDate - date < milliseconds);
}