document.querySelectorAll('.play-pause-button').forEach(button => {
    button.addEventListener('click', e => {
        if(button.classList.contains('playing')) {
            button.classList.remove('paused', 'playing');
            button.classList.add('paused');
            TOGGLE_PLAY_PASUE_FUNC("PAUSE")
        } else {
            if(button.classList.contains('paused')) {
                button.classList.add('playing');
                TOGGLE_PLAY_PASUE_FUNC("PLAY")
            }
        }
        if(!button.classList.contains('paused')) {
            button.classList.add('paused');
            TOGGLE_PLAY_PASUE_FUNC("PAUSE")
        }
    });
});
