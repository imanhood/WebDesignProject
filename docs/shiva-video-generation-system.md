# SHIVA Ω Φ TRUVFY Video Generation System

This document defines a complete, software-ready workflow for turning business inputs into a verified short-form promotional video package. It is intended for coding agents that will generate videos with Remotion, FFmpeg, or MoviePy.

## Required Inputs

| Field | Allowed Values | Notes |
| --- | --- | --- |
| `business_or_product` | string | Product, service, event, or brand name. |
| `business_description` | string | Plain-language description of what is offered. |
| `target_audience` | string | Primary audience segment. |
| `main_offer` | string | Offer or next step. Use factual language only. |
| `goal` | `awareness`, `sales`, `leads`, `booking`, `launch` | Conversion objective. |
| `platform` | `TikTok`, `Instagram Reels`, `YouTube Shorts`, `Facebook Reels`, `LinkedIn` | Determines framing and tone. |
| `duration` | `6`, `8`, `10`, `12`, `15` | Total video length in seconds. |
| `tone` | `professional`, `luxury`, `fun`, `emotional`, `bold`, `inspirational` | Guides visuals, music, and copy. |
| `brand_colors` | string array | Hex, RGB, or named brand colors. |
| `website` | URL or empty | Use only as a source if available. |
| `logo` | asset path, URL, or empty | Use in opening/end-card if available. |
| `sources.urls` | URL array | Optional source retrieval inputs. |
| `sources.uploaded_documents` | file array | Optional source retrieval inputs. |

## SHIVA Engine

Derive the following before writing scenes:

1. **Core message**: one sentence that states what the business helps the audience do.
2. **Primary benefit**: the clearest practical benefit supported by inputs or verified sources.
3. **Emotional driver**: the human motivation behind the purchase or action.
4. **CTA**: the lowest-friction next step aligned to the goal.
5. **Conversion objective**: measurable action, such as click, book, sign up, call, or follow.

## Φ Humanity Layer

Every generated package must optimize for:

- Human value and clear usefulness.
- Plain-language clarity.
- Trust-building proof without exaggeration.
- Accessibility through captions, contrast, and readable pacing.
- Long-term reputation over short-term hype.

The system must avoid:

- Manipulative urgency.
- Fear tactics.
- Unsupported superlatives.
- Invented statistics, testimonials, certifications, awards, or achievements.
- Claims that cannot be verified or directly supported by supplied material.

## TRUVFY Verification Engine

### Claim Classification

| Status | Meaning | Usage Rule |
| --- | --- | --- |
| `Verified` | Confirmed by at least two independent reliable sources. | May be used. |
| `Supported` | Directly supported by supplied business material or one reliable source. | May be used if phrased modestly. |
| `Weak Support` | Plausible but insufficiently documented. | Exclude from final creative copy. |
| `Unverified` | No support found. | Exclude. |
| `Disputed` | Conflicting evidence exists. | Exclude unless the dispute itself is the topic. |

### Verification Rules

1. Retrieve supplied URLs and uploaded documents when available.
2. Extract factual claims from source text and user inputs.
3. Require at least two independent sources for major external claims.
4. Use only `Verified` and `Supported` claims in storyboard, captions, and voiceover.
5. Record excluded claims with reason.
6. Generate a confidence score from `0.0` to `1.0`.

### Confidence Score Guidance

- `0.90-1.00`: all major claims verified by independent sources.
- `0.75-0.89`: major claims verified or directly supported; minor details limited.
- `0.50-0.74`: only supplied material supports the usable claims.
- `<0.50`: insufficient material; generate a generic value-focused video with no factual proof claims.

## Duration Structures

| Duration | Required Structure |
| --- | --- |
| 6 seconds | Hook → Benefit → CTA |
| 8 seconds | Hook → Benefit → CTA |
| 10 seconds | Hook → Problem → Solution → CTA |
| 12 seconds | Problem → Solution → Benefit → CTA |
| 15 seconds | Hook → Problem → Solution → Benefit → CTA |

## Required Output Sections

The generator must produce these sections in order.

### Section 1: Verification Report

Include:

- Sources used.
- Independent source count.
- Verified claims.
- Excluded claims.
- Confidence score.

### Section 2: Video Strategy

Include:

- Marketing angle.
- Audience profile.
- Emotional trigger.
- Desired action.
- CTA strategy.

### Section 3: Video Storyboard

For every scene include:

- Scene ID.
- Start time.
- End time.
- Duration.
- Purpose.
- Visual description.
- Camera movement.
- Overlay text.
- Voiceover text.
- Transition.

### Section 4: Asset Requirements

Include:

- Images required.
- Video clips required.
- Logo files required.
- Icons required.
- Backgrounds required.
- Music style required.
- Sound effects required.

### Section 5: Voiceover Script

Generate complete narration optimized for the requested duration. Recommended speaking pace is 2.0 to 2.5 words per second for short-form ads.

### Section 6: Caption File

Generate SRT-compatible captions with exact timecodes and concise lines.

### Section 7: JSON Output

Generate machine-readable JSON using `docs/shiva-video-package.schema.json`.

### Section 8: Codex Implementation Plan

Include technical instructions for Remotion, FFmpeg, and MoviePy:

- Timeline and sequencing.
- Transitions.
- Caption placement.
- Animation timing.
- Rendering settings.

### Section 9: Optional Source Retrieval

If URLs or documents are supplied:

1. Retrieve content.
2. Extract facts.
3. Run TRUVFY verification.
4. Build storyboard only from verified or supported facts.

## Implementation Defaults

- Aspect ratio: `9:16` for TikTok, Instagram Reels, YouTube Shorts, and Facebook Reels; `1:1` or `4:5` may be used for LinkedIn if requested.
- Default resolution: `1080x1920` for vertical video.
- Default FPS: `30`.
- Safe area: keep text within the center `80%` width and `78%` height.
- Captions: bottom third, high contrast, max two lines.
- Text: minimum 48 px for mobile vertical video.
- Logo: use on first or final scene only unless brand recognition is the main goal.
- CTA: final one to two seconds; avoid flashing or deceptive urgency.

## Example High-Level Generation Procedure

1. Validate inputs against allowed values.
2. Retrieve optional sources.
3. Extract and classify claims.
4. Select the duration structure.
5. Draft strategy from the SHIVA engine outputs.
6. Build scenes with exact timings that sum to the requested duration.
7. Generate voiceover and captions from the approved claims only.
8. Produce asset list and implementation plan.
9. Validate JSON against the schema.
10. Render with the selected video stack.
